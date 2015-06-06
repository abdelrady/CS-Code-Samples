// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.


// README
//
// There are two steps to adding a property:
//
// 1. Create a member variable to store your property
// 2. Add the get_ and set_ accessors for your property.
//
// Remember that both are case sensitive!
//

Type.registerNamespace('Microsoft.Mtps.Web.UI');

Microsoft.Mtps.Web.UI.InlineEditorBehavior = function(element)
{
  Microsoft.Mtps.Web.UI.InlineEditorBehavior.initializeBase(this, [element]);

  this._component = null;
	this._deviceType = "";
	this._editOnStartup = false;
	this._focusOnStart = false;
  this._element = element;
  this._toolbarImageUrl = "";
  this._toolbarSettings = "";
	this._onDoubleClick = "";
}

Microsoft.Mtps.Web.UI.InlineEditorBehavior.prototype =
{
  initialize : function()
  {
    Microsoft.Mtps.Web.UI.InlineEditorBehavior.callBaseMethod(this, 'initialize');
    
    this._component = $create( Microsoft.Mtps.Web.UI.InlineEditor,
          { deviceType: this._deviceType,
            doubleClick: this._onDoubleClick,
            focusOnStart: this._focusOnStart,
            toolbarImageUrl: this._toolbarImageUrl,
            toolbarSettings: this._toolbarSettings },
          null,
          null,
          $(this._element.id));

	  if ( this._editOnStartup == true )
	  {
		  this._component.switchToEditMode();
	  }
  },

  dispose : function()
  {
    Microsoft.Mtps.Web.UI.InlineEditorBehavior.callBaseMethod(this, 'dispose');
  },
  
  // Properties
	
	get_DeviceType : function()
	{
		return this._deviceType;
	},

  set_DeviceType : function(value)
  {
	  this._deviceType = value;
  },
	
	get_DoubleClick : function()
	{
		return this._onDoubleClick;
	},

  set_DoubleClick : function(value)
  {
		this._onDoubleClick = value;
  },
	
	get_EditOnStartup : function()
	{
		return this._editOnStartup;
	},

  set_EditOnStartup : function(value)
  {
  	this._editOnStartup = value;
  },
	
	get_FocusOnStart : function()
	{
		return this._focusOnStart;
	},

  set_FocusOnStart : function(value)
  {
		this._focusOnStart = value;
  },
    
  get_ToolbarImageUrl : function()
  {
		return this._toolbarImageUrl;
   },
    
  set_ToolbarImageUrl : function(value)
  {
		this._toolbarImageUrl = value;
  },
    
  get_ToolbarSettings : function()
  {
		return this._toolbarSettings;
  },
    
  set_ToolbarSettings : function(value)
  {
		this._toolbarSettings = value;
  },
	
	get_OriginalContent : function()
	{
		return this._component.get_originalContent();
	},
	
	set_OriginalContent : function(value)
	{
		this._component.set_originalContent(value);
	},
	
	get_ModifiedContent : function()
	{
		return this._component.get_content();
	},
	
	// Methods
	
	getControlContent : function(id)
	{
		return this._component.getControlContent(id);
	},
    
  switchToEditMode : function()
  {
		this._component.switchToEditMode();
  },
    
  switchToViewMode : function()
  {
		this._component.switchToViewMode();
  }
}

Microsoft.Mtps.Web.UI.InlineEditorBehavior.registerClass('Microsoft.Mtps.Web.UI.InlineEditorBehavior', AjaxControlToolkit.BehaviorBase);

if(typeof(Sys)!=='undefined')Sys.Application.notifyScriptLoaded();