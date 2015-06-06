// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.

Type.registerNamespace('Microsoft.Mtps.Web.UI');

Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection = function() {
    /// <summary>
    /// The CollapsiblePanelExpandDirection enumeration describes whether the panel is opened vertically or horizontally
    /// </summary>
    /// <field name="Horizontal" type="Number" integer="true" static="true" />
    /// <field name="Vertical" type="Number" integer="true" static="true" />
    throw Error.invalidOperation();
}
Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.prototype = {
    Horizontal : 0,
    Vertical: 1
}
Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.registerEnum("Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection", false);

Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior = function(element) {
    Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior.initializeBase(this, [element]);
    
    // composited behaviors
    this._animation = null;
    
    // property values
    this._collapsedSize = 0;
    this._expandedSize = 0;
    this._scrollContents = null;    
    this._collapsed = false;    
    this._expandControlID = null;
    this._collapseControlID = null;
    this._textLabelID = null;    
    this._collapsedText = null;
    this._expandedText = null;
    this._imageControlID = null;
    this._expandedImage = null;
    this._collapsedImage = null;
    this._suppressPostBack = null;
    this._autoExpand = null;
    this._autoCollapse = null;
    this._expandDirection = Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical;
    
    // handler delegates
    this._collapseClickHandler = null;
    this._expandClickHandler = null;    
    this._mouseEnterHandler = null;    
    this._mouseLeaveHandler = null;
    
    // the div we wrap around the panel contents
    this._parentDiv = null;
}

Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior.prototype = {    
    // overrides
    //    
    initialize : function() {
        Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior.callBaseMethod(this, 'initialize');
        
        var element = this.get_element();
        element.style.display = "block";
        this._animation = new AjaxControlToolkit.Animation.LengthAnimation(element, .1, 10, 'style', null, 0, 0, 'px');
        if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical) {
            this._animation.set_propertyKey('height');
        } else if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Horizontal) {
           this._animation.set_propertyKey('width');
        }
        this._animation.add_ended(Function.createDelegate(this, this._onAnimateComplete));
        
        // for checkboxes, we don't want to suppress the posback (e.g. return false)
        // because that stops them from toggling their state.
        //           
        if (this._suppressPostBack == null) {
            if (element.tagName == "INPUT" && element.type == "checkbox") {
                this._suppressPostBack = false;
                this.raisePropertyChanged('SuppressPostBack');
            }                    
            else if (element.tagName == "A") {
                this._suppressPostBack = true;
                this.raisePropertyChanged('SuppressPostBack');
            }
        }
        
        
        // Check our client state.  If it's present,
        // that means this is a postback, so we restore the state.
        //
        var lastState = Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior.callBaseMethod(this, 'get_ClientState');                
        if (lastState && lastState != "") {
            var wasCollapsed = Boolean.parse(lastState);  
            if (this._collapsed != wasCollapsed) {
                this._collapsed = wasCollapsed;
                this.raisePropertyChanged('Collapsed');       
            }
        }
        
        this._setupParentDiv();        
        
        // setup the initial size and state
        //
        
        if (this._collapsed) {
            this._setTargetSize(this._getCollapsedSize());            
        } else {            
            this._setTargetSize(this._getExpandedSize());
        } 
        
        this._setupState(this._collapsed);
        
        // setup all of our handlers.
        if (this._collapseControlID == this._expandControlID) {
            this._collapseClickHandler = Function.createDelegate(this, this._toggle);
            this._expandClickHandler = null; // we don't need both if we're toggling.
        } else {
            this._collapseClickHandler = Function.createDelegate(this, this._doClose);
            this._expandClickHandler = Function.createDelegate(this, this._doOpen);       
        }
        
        if (this._autoExpand) {
            this._mouseEnterHandler = Function.createDelegate(this, this._onMouseEnter);
            $addHandler(element, 'mouseover', this._mouseEnterHandler);
        }       
        if (this._autoCollapse) {
            this._mouseLeaveHandler = Function.createDelegate(this, this._onMouseLeave);
            $addHandler(element, 'mouseout', this._mouseLeaveHandler);
        }
        
        // attach the click handlers
        //
        if (this._collapseControlID) {
            var collapseElement = $get(this._collapseControlID);
            if (!collapseElement) {
                throw Error.argument('CollapseControlID', "Failed to find element '" + this._collapseControlID + "'");
            } else {
                $addHandler(collapseElement, 'click', this._collapseClickHandler);
            }
        }
        
        if (this._expandControlID) {
            if (this._expandClickHandler) { // if it's a toggle don't set up again
                var expandElement = $get(this._expandControlID);
                if (!expandElement) {
                    throw Error.argument('ExpandControlID', "Failed to find element '" + this._expandControlID + "'");
                } else {
                    $addHandler(expandElement, 'click', this._expandClickHandler);
                }
            }
        }
    },
    
    dispose : function() {
        var element = this.get_element();
        
        if (this._collapseClickHandler) {
            var collapseElement = (this._collapseControlID ? $get(this._collapseControlID) : null);
            if (collapseElement) {
                $removeHandler(collapseElement, 'click', this._collapseClickHandler);
            }
            this._collapseClickHandler = null;
        }
        
        if (this._expandClickHandler) {
            var expandElement = (this._expandControlID ? $get(this._expandControlID) : null);
            if (expandElement) {
                $removeHandler(expandElement, 'click', this._expandClickHandler);
            }
            this._expandClickHandler = null;
        }
        
        if (this._mouseEnterHandler) {
            $removeHandler(element, 'mouseover', this._mouseEnterHandler);
        }
        
        if (this._mouseLeaveHandler) {
            $removeHandler(element, 'mouseout', this._mouseLeaveHandler);
        }
        
        if (this._animation) {
            this._animation.dispose();
            this._animation = null;
        }
        
        Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior.callBaseMethod(this, 'dispose');
    },
    
//    getDescriptor : function() {
//        var td = Microsoft.Mtps.Rendering.Behaviors.Ajax.CollapsiblePanelBehavior.callBaseMethod(this, 'getDescriptor');
//        
//        // lots of properties to add here
//        //
//        td.addProperty('CollapsedSize', Number);        
//        td.addProperty('ExpandedSize', Number);        
//        td.addProperty('CollapseControlID', String);        
//        td.addProperty('ExpandControlID', String);        
//        td.addProperty('Collapsed', Boolean);
//        td.addProperty('ScrollContents', Boolean);
//        td.addProperty('SuppressPostBack', Boolean);
//        td.addProperty('AutoExpand', Boolean);        
//        td.addProperty('AutoCollapse', Boolean);        
//        td.addProperty('CollapsedText', String);
//        td.addProperty('ExpandedText', String);
//        td.addProperty('TextLabelID', String);
//        td.addProperty('CollapsedImage', String);
//        td.addProperty('ExpandedImage', String);
//        td.addProperty('ImageControlID', String);
//        td.addProperty('ExpandDirection', Microsoft.Mtps.Rendering.Behaviors.Ajax.CollapsiblePanelExpandDirection);
//        
//        // these are for internal use
//        //
//        td.addProperty('TargetHeight', Number);
//        td.addProperty('TargetWidth', Number);
//        
//        // events
//        //
//        td.addEvent('collapseComplete', true);
//        td.addEvent('expandComplete', true);
//        
//        return td;
//    },

    togglePanel : function(eventObj) {
        /// <summary>
        /// Event handler to epxand or collapse the panel (based on its current state)
        /// This is the public function that should be called instead of _toggle if
        /// you wish to programmatically open and close the collapsible panel.
        /// </summary>
        /// <param name="eventObj" type="Sys.UI.DomEvent" mayBeNull="true" optional="true">
        /// Event Info
        /// </param>

        this._toggle(eventObj);
    },    
    
    expandPanel : function(eventObj) {
        /// <summary>
        /// Open the panel. Public function that users should call if they
        /// wish to operate the collapsible panel programmatically.
        /// _doOpen should be treated as private since it has an underscore 
        /// to begin the function name.
        /// </summary>    
        /// <param name="eventObj" type="Sys.UI.DomEvent" mayBeNull="true" optional="true">
        /// Event Info
        /// </param>
        
        this._doOpen(eventObj);    
    },
    
    collapsePanel : function(eventObj) {
        /// <summary>
        /// Collapse the panel. Public function that users should call if they
        /// wish to operate the collapsible panel programmatically.
        /// _doClose should be treated as private since it has an underscore 
        /// to begin the function name.
        /// </summary>    
        /// <param name="eventObj" type="Sys.UI.DomEvent" mayBeNull="true" optional="true">
        /// Event Info
        /// </param>
        
        this._doClose(eventObj);
    },
    
    _checkCollapseHide : function() {
        if (this._collapsed || this._getTargetSize() == 0) {
            var e = this.get_element();
            var display = CommonToolkitScripts.getCurrentStyle(e, 'display');
            if (!e.oldDisplay && display != "none") {
                e.oldDisplay = display;
                e.style.display = "none";
            }
            return true;
        }
        return false;
    },
    
    _doClose : function(eventObj) {
    
        if (this._animation) {
            // stop any running animation.
            //
            this._animation.stop();        
            
            // setup the animation state
            //   
            this._animation.set_startValue(this._getTargetSize());
            this._animation.set_endValue(this._getCollapsedSize());
            
            // do it!
            //
            this._animation.play();
        
        }
        
        this._setupState(true);
                
        // stop postback if necessary.
        //
        if (this._suppressPostBack) {
            if (eventObj && eventObj.preventDefault) {
                eventObj.preventDefault();
            } else {
                event.returnValue = false;
                return false;
            }
        }
    },
    
    //
    // Perform the opening animation.
    //
    _doOpen : function(eventObj) {

        // stop any existing animation
        //
        if (this._animation) {
            this._animation.stop();
            var e = this.get_element();
            
            if (this._checkCollapseHide() && CommonToolkitScripts.getCurrentStyle(e, 'display', e.style.display)) {
                if (e.oldDisplay) {
                    e.style.display = e.oldDisplay;
                    e.style.height = "auto";
                } else {
                    // IE isn't compliant on this one...
                    if (e.style.removeAttribute) {
                        e.style.removeAttribute("display");
                    } else {
                       e.style.removeProperty("display");
                    }
                }
                e.oldDisplay = null;
            }
            
            // setup the animation state
            //        
            this._animation.set_startValue(this._getTargetSize());
            this._animation.set_endValue(this._getExpandedSize());
            
            // do it!
            //
            this._animation.play();
        }
        
        // relect our state changes
        //
        this._setupState(false);
        
        // stop the postback if necessary.
        //
        if (this._suppressPostBack) {
            if (eventObj && eventObj.preventDefault) {
                eventObj.preventDefault();
            } else {
                event.returnValue = false;
                return false;
            }
        }
    },
    
    _onAnimateComplete : function() {

        var e = this.get_element();
    
        // if we're fully expanded and the inner pannel is still smaller
        // than the size we've expanded to, fall back to auto
        //    
        if (!this._collapsed && !this._expandedSize
         && this._parentDiv.offsetHeight <= e.offsetHeight) {
            e.style.height = "auto";
            this.raisePropertyChanged('TargetHeight');
        } else {
            this._checkCollapseHide();
        }
        
        if (this._collapsed) {
            this.raiseCollapseComplete();
        } else {
            this.raiseExpandComplete()
        }
    },
    
    _onMouseEnter : function() {
        if (this._autoExpand) {
            this._doOpen();
        }
    },
    
    _onMouseLeave : function() {
        if (this._autoCollapse) {
           this._doClose();
        }
    },
    
    // Helper methods to set the dimensions that we're targeting
    //
    
    _getExpandedSize : function() {
    
        if (this._expandedSize) {
            return this._expandedSize;
        }                
        
        if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical) {
            return this._parentDiv.offsetHeight;
        } else if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Horizontal) {
            return this._parentDiv.offsetWidth;
        }
    },
    
    _getCollapsedSize : function() {
        if (this._collapsedSize) {
            return this._collapsedSize;
        }
        
        return 0;
    },
    
     _getTargetSize : function() {
        var value;
        if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical) {
           value = this.get_TargetHeight();
        } else if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Horizontal) {
           value = this.get_TargetWidth();
        }       
        
        // Safari returns undefined if display is 'none'
        //
        if (value === undefined) {
            value = 0;
        }
        return value;
    },
    
    _setTargetSize : function(value) {
    
        // we don't always want to set the target size here.
        // if we don't have an expanded size, and we're not collapsed,
        // and we're at (or past) our "maximum" size
        //
        var useSize = this._collapsed || this._expandedSize;
        var e = this.get_element();
        if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical) {
            if (useSize || value < e.offsetHeight) {
                this.set_TargetHeight(value);
            } else {
                // if we're at our maximum size, flip to auto 
                // so that nested collapsible panels will
                // work properly.
                //
                e.style.height = "auto";
                this.raisePropertyChanged('TargetHeight');
            }
        } else if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Horizontal) {
            if (useSize || value < e.offsetWidth) {
                this.set_TargetWidth(value);
            }
            else {
                e.style.width = "auto";
                this.raisePropertyChanged('TargetWidth');
            }            
        }
        this._checkCollapseHide();
    },
    
    // sets up a parent div to host our panel contents
    // and then pushes the panel's children into it.
    //
    _setupParentDiv : function() {
        
        
        var startSize = this._getTargetSize();
        
        var e = this.get_element();
                
        this._parentDiv = e.cloneNode(false);
        this._parentDiv.id = '';
        
        // move all children into the div.
        //
        while (e.hasChildNodes()) {            
            var child = e.childNodes[0];
            child = e.removeChild(child);
            this._parentDiv.appendChild(child);                
        }

        //Delete some style after cloneNode
        //On Clone
        this._parentDiv.style.position = ""; 
        this._parentDiv.style.border   = ""; 
        this._parentDiv.style.margin   = ""; 
        //On Parent
        e.style.padding = "";

                
        if (this._scrollContents) {        
            e.style.overflow = "scroll";
         }
         else {
          if (this._collapsed)
          {
            e.style.overflow = "hidden";
          }
          else
          {
            e.style.overflow = "visible";
          }
         }
                
        // we optimize for the case where the original size is the collapsed size.
        // if that's the case, we go ahead and set the inner panel to auto so you 
        // can still expand it but not see it expanded by default when the page loads.
        //
        if (startSize == this._collapsedSize) {
            if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical) {
                this._parentDiv.style.height = "auto"; 
            } else if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Horizontal) {
                this._parentDiv.style.width = "auto"; 
            }
        }
        
        e.appendChild(this._parentDiv);
        
        if (this._collapsed) {
            startSize = this._getCollapsedSize();
        }
        else {
            startSize = this._getExpandedSize();
        }
            
        // set up our initial size
        //    
        if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical) {
            e.style.height = startSize + "px";
            e.style.width = CommonToolkitScripts.getCurrentStyle(this._parentDiv, 'width');
            
            if (!this._expandedSize) {                                         
                e.style.height = "auto";
            }
            else {
               e.style.height = this._expandedSize + "px";
            }
            
        } else if (this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Horizontal) {
            e.style.height = CommonToolkitScripts.getCurrentStyle(this._parentDiv, 'height');
            e.style.width = startSize + "px";
            
            //e.style.width = this._getExpandedSize() + "px";
  
            if (!this._expandedSize) {                                         
                e.style.width = "auto";
            }
            else {
               e.style.width = this._expandedSize + "px";
            }
        }    
    },
    
    // helper method to get all the state set consistantly
    // when we change modes.
    //
    _setupState : function(isCollapsed) {
    
        if (isCollapsed) {           
        
            // change the text label ID if we have one.
            //
            if (this._textLabelID && this._collapsedText) {
                var e = $get(this._textLabelID);
                
                if (e) {
                    e.innerHTML = this._collapsedText;
                }
            }
            
            // Change the image if we have one
            if (this._imageControlID && this._collapsedImage) {
                var i = $get(this._imageControlID);
                if (i && i.src) {
                    i.src = this._collapsedImage;
                    if (this._expandedText || this._collapsedText) {
                        i.title = this._collapsedText;
                    }
                }
            }            
        }
        else {  
            if (this._textLabelID && this._expandedText) {
                var e = $get(this._textLabelID);
                
                if (e) {
                    e.innerHTML = this._expandedText;
                }
            }
            
            // Change the image if we have one
            if (this._imageControlID && this._expandedImage) {
                var i = $get(this._imageControlID);
                if (i && i.src) {
                    i.src = this._expandedImage;
                    if (this._expandedText || this._collapsedText) {
                            i.title = this._expandedText;
                    }
                }
            }        
        } 
        
        // set our member variable and set the client state to reflect it
        // 
        if (this._collapsed != isCollapsed) {
            this._collapsed = isCollapsed;        
            this.raisePropertyChanged('Collapsed');
        }
        Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior.callBaseMethod(this, 'set_ClientState', [this._collapsed.toString()]);                        
    },
    
    _toggle : function(eventObj) {
        if (this.get_Collapsed()) {
            return this._doOpen(eventObj);
        } else {
            return this._doClose(eventObj);
        }
    },

    //    
    // events
    //
    
    add_collapseComplete : function(handler) {
    	this.get_events().addHandler('collapseComplete', handler);
    },
    remove_collapseComplete : function(handler) {
    	this.get_events().removeHandler('collapseComplete', handler);
    },
    raiseCollapseComplete : function() {
    	var handlers = this.get_events().getHandler('collapseComplete');
    	if (handlers) {
    		handlers(this, Sys.EventArgs.Empty);
    	}
    },
    
    add_expandComplete : function(handler) {
    	this.get_events().addHandler('expandComplete', handler);
    },
    remove_expandComplete : function(handler) {
    	this.get_events().removeHandler('expandComplete', handler);
    },
    raiseExpandComplete : function() {
    	var handlers = this.get_events().getHandler('expandComplete');
    	if (handlers) {
    		handlers(this, Sys.EventArgs.Empty);
    	}
    },

    //
    // Properties to wrap the height/width
    //
    
    get_TargetHeight : function() {    
        return this.get_element().offsetHeight;        
    },
    set_TargetHeight : function(value) {        
        this.get_element().style.height = value + "px";        
        this.raisePropertyChanged('TargetHeight');
    },
    
    get_TargetWidth : function() {    
        return this.get_element().offsetWidth;        
    },
    set_TargetWidth : function(value) {
        this.get_element().style.width = value + "px"        
        this.raisePropertyChanged('TargetWidth');
    },
    
    // 
    // Property accessors
    //
        
    get_Collapsed : function() {
        return this._collapsed;        
    },
    
    set_Collapsed : function(value) {
        
        // if we're changing values, and we're live, toggle.
        //
        if (this.get_isInitialized() && this.get_element() && value != this.get_Collapsed()) {
            this._toggle();
        }
        else {
            this._collapsed = value;
            this.raisePropertyChanged('Collapsed');
        }
    },
    
    get_CollapsedSize : function() {
        return this._collapsedSize;
    },
    
    set_CollapsedSize : function(value) {
        if (this._collapsedSize != value) {
            this._collapsedSize = value;
            this.raisePropertyChanged('CollapsedSize');
        }
    },
    
    
    get_ExpandedSize : function() {
        return this._expandedSize;
    },
    
    set_ExpandedSize : function(value) {
        if (this._expandedSize != value) {
            this._expandedSize = value;
            this.raisePropertyChanged('ExpandedSize');
        }
    },
    
    get_CollapseControlID : function() {
        return this._collapseControlID;
    },
    
    set_CollapseControlID : function(value) {
        if (this._collapseControlID != value) {
            this._collapseControlID = value;
            this.raisePropertyChanged('CollapseControlID');
        }
    },
    
    get_ExpandControlID : function() {
        return this._expandControlID;
    },
    
    set_ExpandControlID : function(value) {
        if (this._expandControlID != value) {
            this._expandControlID = value;
            this.raisePropertyChanged('ExpandControlID');
        }
    },
    
     get_ScrollContents : function() {
        return this._scrollContents;
    },
    
    set_ScrollContents : function(value) {
        if (this._scrollContents != value) {
            this._scrollContents = value;
            this.raisePropertyChanged('ScrollContents');
        }
    },
    
     get_SuppressPostBack : function() {
        return this._suppressPostBack;
    },
    
    set_SuppressPostBack : function(value) {
        if (this._suppressPostBack != value) {
            this._suppressPostBack = value;
            this.raisePropertyChanged('SuppressPostBack');
        }
    },
    
    get_TextLabelID : function() {
        return this._textLabelID;
    },
    
    set_TextLabelID : function(value) {
        if (this._textLabelID != value) {
            this._textLabelID = value;
            this.raisePropertyChanged('TextLabelID');
        }
    },
    
      get_ExpandedText : function() {
        return this._expandedText;
    },
    
    set_ExpandedText : function(value) {
        if (this._expandedText != value) {
            this._expandedText = value;
            this.raisePropertyChanged('ExpandedText');
        }
    },
    
      get_CollapsedText : function() {
        return this._collapsedText;
    },
    
    set_CollapsedText : function(value) {
        if (this._collapsedText != value) {
            this._collapsedText = value;
            this.raisePropertyChanged('CollapsedText');
        }
    },
    
    get_ImageControlID : function() {
        return this._imageControlID;
    },
    
    set_ImageControlID : function(value) {
        if (this._imageControlID != value) {
            this._imageControlID = value;
            this.raisePropertyChanged('ImageControlID');
        }
    },
    
      get_ExpandedImage : function() {
        return this._expandedImage;
    },
    
    set_ExpandedImage : function(value) {
        if (this._expandedImage != value) {
            this._expandedImage = value;
            this.raisePropertyChanged('ExpandedImage');
        }
    },
    
    get_CollapsedImage : function() {
        return this._collapsedImage;
    },
    
    set_CollapsedImage : function(value) {
        if (this._collapsedImage != value) {
            this._collapsedImage = value;
            this.raisePropertyChanged('CollapsedImage');
        }
    },
    
    get_AutoExpand : function() {
        return this._autoExpand;
    },
    
    set_AutoExpand : function(value) {
        if (this._autoExpand != value) {
            this._autoExpand = value;
            this.raisePropertyChanged('AutoExpand');
        }
    },
    
    get_AutoCollapse : function() {
        return this._autoCollapse;
    },
    
    set_AutoCollapse : function(value) {
        if (this._autoCollapse != value) {
            this._autoCollapse = value;
            this.raisePropertyChanged('AutoCollapse');
        }
    },    
    
    get_ExpandDirection : function() {
        return this._expandDirection == Microsoft.Mtps.Web.UI.CollapsiblePanelExpandDirection.Vertical;
    },
       
    set_ExpandDirection : function(value) {
        if (this._expandDirection != value) {
            this._expandDirection = value;
            this.raisePropertyChanged('ExpandDirection');
        }
    }
}

Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior.registerClass('Microsoft.Mtps.Web.UI.CollapsiblePanelBehavior', AjaxControlToolkit.BehaviorBase);


if(typeof(Sys)!=='undefined')Sys.Application.notifyScriptLoaded();