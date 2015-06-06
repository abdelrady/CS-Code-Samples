Type.createNamespace('Microsoft.Mtps.Rendering.Behaviors.Ajax');Microsoft.Mtps.Rendering.Behaviors.Ajax.ButtonStates=Type.createEnum(false,'Microsoft.Mtps.Rendering.Behaviors.Ajax.ButtonStates',{Up:0,Highlighted:1,Down:2,Disabled:3});Microsoft.Mtps.Rendering.Behaviors.Ajax.InlineEditor=function(elem){Microsoft.Mtps.Rendering.Behaviors.Ajax.InlineEditor.constructBase(this,[elem]);}Microsoft.Mtps.Rendering.Behaviors.Ajax.InlineEditor.prototype={_editElement:null,_onBlur:null,_onDoubleClick:null,_onDrop:null,_onFocus:null,_onPaste:null,_onResize:null,_onRefresh:null,_preventKeyPress:null,_selection:null,_toolbar:null,_selectionType:null,_originalContent:null,_toolbarImageUrl:null,_toolbarSettings:null,_doubleClickEventHandler:null,_deviceType:null,_editSourceHeight:0,_focusOnStart:false,_isEditing:false,_isPasting:false,_hasFocus:false,get_content:function(){return this.$2_2();},set_content:function(value){this.$2_E(value);return value;},get_deviceType:function(){return this._deviceType;},set_deviceType:function(value){this._deviceType=value;return value;},get_doubleClick:function(){return this._doubleClickEventHandler;},set_doubleClick:function(value){this._doubleClickEventHandler=value;return value;},get_focusOnStart:function(){return this._focusOnStart;},set_focusOnStart:function(value){this._focusOnStart=value;return value;},get_hasFocus:function(){return this._hasFocus;},get_isContentChanged:function(){return (String.compare(this._originalContent,this.$2_2()));},get_isEditing:function(){return this._isEditing;},get_originalContent:function(){return this._originalContent;},set_originalContent:function(value){this._originalContent=value;return value;},get_sourceElementID:function(){return this.get_element().id;},get_toolbarImageUrl:function(){return this._toolbarImageUrl;},set_toolbarImageUrl:function(value){this._toolbarImageUrl=value;return value;},get_toolbarSettings:function(){return this._toolbarSettings;},set_toolbarSettings:function(value){this._toolbarSettings=value;return value;},$2_0:function(){this._originalContent=this.get_element().innerHTML;var $0;if(isNullOrUndefined(document.all)){$0=document.createElement('iframe');$0.id=this.get_element().id+'$edit';$0.setAttribute('name',$0.id);$0.style.position='relative';$0.style.width='100%';this._editSourceHeight=this.get_element().clientHeight;if(this.get_element().clientHeight<120){$0.style.height='120px';}else{$0.style.height=this.get_element().clientHeight+'px';}$0.style.overflow='auto';$0.style.margin='0px';$0.style.padding='0px';$0.style.border='1px solid #87A9D1';$0.style.display='none';this.get_element().parentNode.insertBefore($0,this.get_element().nextSibling);this.get_element().parentNode.style.overflowX='hidden';var $1=($0).contentWindow.document;$1.open();$1.write('<HTML><HEAD></HEAD><BODY></BODY></HTML>');$1.close();var $2=this.get_element().innerHTML;if(String.isNullOrEmpty($2)){$2='<BR>';}$1.body.innerHTML=$2;$1.body.style.margin='0px';$1.body.style.padding='0px';}else{$0=this.get_element();}return $0;},$2_1:function(){if(!isNullOrUndefined(document.all)){this._selection=this.getDocument().selection.createRange();this._selectionType=this.getDocument().selection.type;}},dispose:function(){if(this._isEditing){this.getEditElement().detachEvent('onblur',this._onBlur);this.getEditElement().detachEvent('ondrop',this._onDrop);this.getEditElement().detachEvent('onfocus',this._onFocus);this.getEditElement().detachEvent('onmouseup',this._onRefresh);this.getEditElement().detachEvent('onkeyup',this._onRefresh);this.getEditElement().detachEvent('onpaste',this._onPaste);if(isNullOrUndefined(document.all)){window.detachEvent('onresize',this._onResize);}}else{this.get_element().detachEvent('ondblclick',this._onDoubleClick);}this.getEditElement().detachEvent('onkeypress',this._preventKeyPress);this._toolbar.dispose();Microsoft.Mtps.Rendering.Behaviors.Ajax.InlineEditor.callBase(this, 'dispose');},$2_2:function(){if(isNullOrUndefined(document.all)){return (this.getEditElement()).contentWindow.document.body.innerHTML;}else{return this.getEditElement().innerHTML;}},getDocument:function(){if(isNullOrUndefined(document.all)){return (this.getEditElement()).contentWindow.document;}else{return window.document;}},getEditElement:function(){return this._editElement;},getExecTarget:function(){if(isNullOrUndefined(document.all)){return null;}else{if(!isNull(this._selection)&&String.compare(this._selectionType,'none',true)||(!String.compare(this._selectionType,'text',true)&&!String.isNullOrEmpty(this._selection.text))){return this._selection;}else{return null;}}},$2_3:function(){this.$2_E(this._originalContent);if(isNullOrUndefined(document.all)){(this.getEditElement()).contentWindow.document.designMode='off';this.getEditElement().style.display='none';this.get_element().style.visibility='visible';this.get_element().style.height=this._editSourceHeight+'px';}else{this.getEditElement().setAttribute('contentEditable','false');}this.getEditElement().className='InlineEditor_Editor_Off';},$2_4:function(){this._toolbar.hide();},initialize:function(){Microsoft.Mtps.Rendering.Behaviors.Ajax.InlineEditor.callBase(this, 'initialize');this._isEditing=false;if(!this._editElement){this._editElement=this.$2_0();}this._onBlur=Delegate.create(this,this.$2_6);this._onDoubleClick=Delegate.create(this,this.$2_7);this._onDrop=Delegate.create(this,this.$2_8);this._onFocus=Delegate.create(this,this.$2_9);this._onPaste=Delegate.create(this,this.$2_A);this._onRefresh=Delegate.create(this,this.$2_B);this._onResize=Delegate.create(this,this.$2_C);this._preventKeyPress=Delegate.create(this,this.$2_D);this.get_element().attachEvent('ondblclick',this._onDoubleClick);this.getEditElement().attachEvent('onkeypress',this._preventKeyPress);this._toolbar=new Microsoft.Mtps.Rendering.Behaviors.Ajax.Toolbar(this.get_element(),this,this._toolbarImageUrl);this.$2_5();this.$2_3();},$2_5:function(){if(!String.isNullOrEmpty(this._toolbarSettings)){var $0=this._toolbarSettings.split(';');var $enum1=$0.getEnumerator();while($enum1.moveNext()){var $1=$enum1.get_current();if(!String.isNullOrEmpty($1)){var $2=$1.split(':');if(!String.isNullOrEmpty($2[0])){switch($2[0]){case 'b':if($2.length==9&&(Boolean.parse($2[7])||!isNullOrUndefined(document.all))&&(Boolean.parse($2[8])||String.compare(this._deviceType,'ide',true))){this._toolbar.$0($2[1],$2[2],$2[3],Number.parse($2[4]),Number.parse($2[5]),$2[6]);}break;case 's':if($2.length==5&&(Boolean.parse($2[3])||!isNullOrUndefined(document.all))&&(Boolean.parse($2[4])||String.compare(this._deviceType,'ide',true))){this._toolbar.$1(Number.parse($2[1]),Number.parse($2[2]));}break;}}}}}},$2_6:function(){this._hasFocus=false;if(!this._toolbar.get_isSelected()){this.$2_B();}},$2_7:function(){eval(this._doubleClickEventHandler+'(this)');},$2_8:function(){if(!this._isPasting){var $0=window.event.dataTransfer.getData('text');window.self.clipboardData.setData('text',$0);this._editElement.focus();this._isPasting=true;this.performCommand('paste',null);this._isPasting=false;window.event.returnValue=false;}},$2_9:function(){this._hasFocus=true;},$2_A:function(){if(!this._isPasting){var $0=window.self.clipboardData.getData('text');if(!String.isNullOrEmpty($0)){window.self.clipboardData.setData('text',$0);this._isPasting=true;this.performCommand('paste',null);this._isPasting=false;}window.event.returnValue=false;}},$2_B:function(){this.$2_1();window.setTimeout(Delegate.create(this,this.refresh),0);},$2_C:function(){if(isNullOrUndefined(document.all)){(this.getEditElement()).style.width=this.get_element().clientWidth+'px';}},performCommand:function(command,commandValue){if(String.isNullOrEmpty(command)){return;}this.$2_1();var $0=this.getExecTarget();this.setFocus();if(!isNull($0)){$0.select();if(!$0.execCommand(command,false,commandValue)){this.getDocument().execCommand(command,false,commandValue);}}else{this.getDocument().execCommand(command,false,commandValue);}},$2_D:function(){window.event.cancelBubble=true;},refresh:function(){this._toolbar.$5();if(isNullOrUndefined(document.all)){(this.getEditElement()).style.width=this.get_element().clientWidth+'px';}},$2_E:function($p0){if(isNullOrUndefined(document.all)){(this.getEditElement()).contentWindow.document.body.innerHTML=$p0;}else{this.getEditElement().innerHTML=$p0;}},setFocus:function(){if(!isNullOrUndefined(document.all)){$(this.getEditElement().id).focus();}else{eval('window.frames[\''+this.getEditElement().id+'\'].focus();');}this.$2_B();},$2_F:function(){if(isNullOrUndefined(document.all)){this.getEditElement().style.display='block';(this.getEditElement()).contentWindow.document.designMode='on';this.get_element().style.visibility='hidden';this.get_element().style.height='0px';}else{this.getEditElement().setAttribute('contentEditable','true');}this.getEditElement().className='InlineEditor_Editor_On';this.$2_E(this._originalContent);this.$2_C();},$2_10:function(){this._toolbar.$7();},$2_11:function(){this.get_element().detachEvent('ondblclick',this._onDoubleClick);this.getEditElement().attachEvent('onblur',this._onBlur);this.getEditElement().attachEvent('ondrop',this._onDrop);this.getEditElement().attachEvent('onfocus',this._onFocus);this.getEditElement().attachEvent('onkeyup',this._onRefresh);this.getEditElement().attachEvent('onmouseup',this._onRefresh);this.getEditElement().attachEvent('onpaste',this._onPaste);if(isNullOrUndefined(document.all)){window.attachEvent('onresize',this._onResize);}this.$2_F();this.$2_10();if(this._focusOnStart){this.setFocus();this._hasFocus=true;}this._isEditing=true;},$2_12:function(){this.get_element().attachEvent('ondblclick',this._onDoubleClick);this.getEditElement().detachEvent('onblur',this._onBlur);this.getEditElement().detachEvent('ondrop',this._onDrop);this.getEditElement().detachEvent('onfocus',this._onFocus);this.getEditElement().detachEvent('onkeyup',this._onRefresh);this.getEditElement().detachEvent('onmouseup',this._onRefresh);this.getEditElement().detachEvent('onpaste',this._onPaste);if(isNullOrUndefined(document.all)){window.detachEvent('onresize',this._onResize);}this.$2_3();this.$2_4();this._isEditing=false;},switchToEditMode:function(){this.$2_11();},switchToViewMode:function(){this.$2_12();}}Microsoft.Mtps.Rendering.Behaviors.Ajax.Button=function(editor,command,commandValue,query,tooltip){this._state=0;this._editor=editor;this._command=command;if(!String.isNullOrEmpty(commandValue)){this._commandValue=commandValue;}else{this._commandValue=null;}this._query=query;this._tooltip=tooltip;this._doCommand=Delegate.create(this,this.$0);this._onMouseDown=Delegate.create(this,this.$1);this._onMouseUp=Delegate.create(this,this.$4);this._onMouseEnter=Delegate.create(this,this.$2);this._onMouseLeave=Delegate.create(this,this.$3);}Microsoft.Mtps.Rendering.Behaviors.Ajax.Button.prototype={_editor:null,_doCommand:null,_onMouseDown:null,_onMouseUp:null,_onMouseEnter:null,_onMouseLeave:null,_command:null,_commandValue:null,_query:null,_tooltip:null,_button:null,$0:function(){if(this._state!=3){this._editor.performCommand(this._command,this._commandValue);}},$1:function(){if(this._state!=3){this.setState(2,true);}},$2:function(){if(this._state!=3&&this._state!=2){this.setState(1,false);}},$3:function(){window.setTimeout(Delegate.create(this,this.$5),0);},$4:function(){window.setTimeout(Delegate.create(this,this.$5),0);},$5:function(){if(!isNullOrUndefined(this._editor)&&!this._editor.get_hasFocus()){this.setState(3,true);return;}if(String.isNullOrEmpty(this._query)){this.setState(0,true);return;}var $0=false;var $1=false;var $2=this._editor.getExecTarget();if(!isNull($2)){$0=$2.queryCommandEnabled(this._query);if($0){$1=$2.queryCommandState(this._query);}}else{$0=this._editor.getDocument().queryCommandEnabled(this._query);if($0){if(!String.compare(this._query,'indent',true)||!String.compare(this._query,'outdent',true)){this.setState(0,true);return;}try{$1=this._editor.getDocument().queryCommandState(this._query);}catch($3){throw new Error('Exception performing QueryCommandState('+this._query+'): '+$3.message);}}}if($0){if($1){this.setState(2,true);}else{this.setState(0,true);}}else{this.setState(3,true);}},refresh:function(){window.setTimeout(Delegate.create(this,this.$5),0);},render:function(parent){this._button=parent;if(!String.isNullOrEmpty(this._tooltip)){this._button.title=this._tooltip;}if(!String.isNullOrEmpty(this._command)){this._button.attachEvent('onclick',this._doCommand);this._button.attachEvent('onmousedown',this._onMouseDown);this._button.attachEvent('onmouseup',this._onMouseUp);this._button.attachEvent('onmouseenter',this._onMouseEnter);this._button.attachEvent('onmouseleave',this._onMouseLeave);}return this._button;},setState:function(state,save){},dispose:function(){if(!isNull(this._button)){this._button.detachEvent('onclick',this._doCommand);this._button.detachEvent('onmousedown',this._onMouseDown);this._button.detachEvent('onmouseup',this._onMouseUp);this._button.detachEvent('onmouseenter',this._onMouseEnter);this._button.detachEvent('onmouseleave',this._onMouseLeave);}}}Microsoft.Mtps.Rendering.Behaviors.Ajax.ImageButton=function(editor,command,commandValue,query,image,offset,width,tooltip){Microsoft.Mtps.Rendering.Behaviors.Ajax.ImageButton.constructBase(this,[editor,command,commandValue,query,tooltip]);this._toolbarImage=image;this._offset=offset;this._width=width;}Microsoft.Mtps.Rendering.Behaviors.Ajax.ImageButton.prototype={_toolbarImage:null,_offset:0,_width:0,_image:null,render:function(parent){var $0=document.createElement('a');$0.tabIndex=-1;$0.className='InlineEditor_ImageButton';$0.setAttribute('href','#');$0.style.styleFloat='left';$0.style.display='inline-block';$0.style.position='relative';$0.style.zIndex=0;$0.style.width=this._width+'px';$0.style.height='24px';if(!isNullOrUndefined(document.all)){$0.style.overflow='hidden';}parent.appendChild($0);var $1=document.createElement('span');$1.style.overflow='hidden';$1.style.clip='rect(0px '+this._width.toString()+'px 24px 0px)';$1.style.position='absolute';$1.style.width=this._width+'px';$1.style.height='24px';$0.appendChild($1);this._image=document.createElement('img');this._image.setAttribute('border','0');this._image.style.position='relative';this._image.style.left=(-this._offset)+'px';this._image.setAttribute('src',this._toolbarImage.getAttribute('src'));$1.appendChild(this._image);return Microsoft.Mtps.Rendering.Behaviors.Ajax.ImageButton.callBase(this, 'render',[$0]);},setState:function(state,save){this._image.style.cursor='pointer';switch(state){case 0:this._image.style.pixelTop=0;break;case 1:this._image.style.pixelTop=-24;break;case 2:this._image.style.pixelTop=-48;break;case 3:this._image.style.pixelTop=-72;this._image.style.cursor='default';break;}if(save){this._state=state;}}}Microsoft.Mtps.Rendering.Behaviors.Ajax.Separator=function(image,offset,width){Microsoft.Mtps.Rendering.Behaviors.Ajax.Separator.constructBase(this,[null,null,null,null,null]);this._toolbarImage=image;this._offset=offset;this._width=width;}Microsoft.Mtps.Rendering.Behaviors.Ajax.Separator.prototype={_toolbarImage:null,_offset:0,_width:0,render:function(parent){var $0=document.createElement('a');$0.tabIndex=-1;$0.setAttribute('href','#');$0.className='InlineEditor_Separator';$0.style.styleFloat='left';$0.style.display='inline-block';$0.style.position='relative';$0.style.zIndex=0;$0.style.width=this._width+'px';$0.style.height='24px';if(!isNullOrUndefined(document.all)){$0.style.overflow='hidden';}parent.appendChild($0);var $1=document.createElement('span');$1.style.overflow='hidden';$1.style.clip='rect(0px '+this._width.toString()+'px 24px 0px)';$1.style.position='absolute';$0.appendChild($1);var $2=document.createElement('img');$2.setAttribute('border','0');$2.style.position='relative';$2.style.left=(-this._offset)+'px';$2.setAttribute('src',this._toolbarImage.getAttribute('src'));$1.appendChild($2);return Microsoft.Mtps.Rendering.Behaviors.Ajax.Separator.callBase(this, 'render',[$0]);},setState:function(state,save){}}Microsoft.Mtps.Rendering.Behaviors.Ajax.TextButton=function(editor,command,commandValue,query,text,tooltip){Microsoft.Mtps.Rendering.Behaviors.Ajax.TextButton.constructBase(this,[editor,command,commandValue,query,text]);this._text=text;}Microsoft.Mtps.Rendering.Behaviors.Ajax.TextButton.prototype={_text:null,render:function(parent){var $0=document.createElement('div');$0.tabIndex=-1;$0.style.display='inline-block';$0.style.styleFloat='left';$0.style.padding='2px';$0.style.pixelHeight=24;if(!isNullOrUndefined(document.all)){$0.style.overflow='hidden';}parent.appendChild($0);var $1=document.createElement('a');$1.innerText=this._text;$1.tabIndex=-1;$1.setAttribute('href','javascript:void()');$1.style.color='black';$1.style.font='10pt Arial';$1.style.verticalAlign='middle';$1.style.whiteSpace='nowrap';$0.appendChild($1);return Microsoft.Mtps.Rendering.Behaviors.Ajax.TextButton.callBase(this, 'render',[$0]);},setState:function(state,save){}}Microsoft.Mtps.Rendering.Behaviors.Ajax.Toolbar=function(elem,parent,imageUrl){this._buttons=[];this._element=elem;this._editor=parent;this._cancelEvent=Delegate.create(this,this.$2);this._onMouseDown=Delegate.create(this,this.$3);this._onMouseUp=Delegate.create(this,this.$4);this._toolbarImage=document.createElement('img');this._toolbarImage.setAttribute('src',imageUrl);this._toolbar=document.createElement('div');this._toolbar.className='InlineEditor_Toolbar';this._toolbar.style.display='none';this._toolbar.style.width='100%';this._toolbar.style.height='24px';this._toolbar.style.whiteSpace='nowrap';if(!isNullOrUndefined(document.all)){this._toolbar.attachEvent('ondrag',this._cancelEvent);this._toolbar.setAttribute('unselectable','on');}else{this._toolbar.attachEvent('onmouseout',this._cancelEvent);}this._toolbar.attachEvent('onmousedown',this._onMouseDown);this._toolbar.attachEvent('onmouseup',this._onMouseUp);this._toolbar.attachEvent('onselectstart',this._cancelEvent);this._element.parentNode.insertBefore(this._toolbar,this._element);}Microsoft.Mtps.Rendering.Behaviors.Ajax.Toolbar.prototype={_editor:null,_element:null,_toolbarImage:null,_toolbar:null,_cancelEvent:null,_onMouseDown:null,_onMouseUp:null,_isSelected:false,get_element:function(){return this._toolbar;},get_isSelected:function(){return this._isSelected;},$0:function($p0,$p1,$p2,$p3,$p4,$p5){if(!String.compare($p0,'FormatBlock',true)){$p1='<'+$p1+'>';}var $0=new Microsoft.Mtps.Rendering.Behaviors.Ajax.ImageButton(this._editor,$p0,$p1,$p2,this._toolbarImage,$p3,$p4,$p5);this._buttons[this._buttons.length]=$0;$0.render(this._toolbar);},$1:function($p0,$p1){var $0=new Microsoft.Mtps.Rendering.Behaviors.Ajax.Separator(this._toolbarImage,$p0,$p1);this._buttons[this._buttons.length]=$0;$0.render(this._toolbar);},$2:function(){window.event.returnValue=false;window.event.cancelBubble=true;},hide:function(){this._toolbar.style.display='none';},$3:function(){this._isSelected=true;},$4:function(){this._isSelected=false;},$5:function(){this._toolbar.style.width=this._element.offsetWidth+'px';var $enum1=this._buttons.getEnumerator();while($enum1.moveNext()){var $0=$enum1.get_current();$0.refresh();}},$6:function(){window.setTimeout(Delegate.create(this,this.$5),0);},$7:function(){this._toolbar.style.display='block';this.$5();},dispose:function(){if(!isNullOrUndefined(document.all)){this._toolbar.detachEvent('ondrag',this._cancelEvent);}else{this._toolbar.detachEvent('onmouseout',this._cancelEvent);}this._toolbar.detachEvent('onmousedown',this._onMouseDown);this._toolbar.detachEvent('onmouseup',this._onMouseUp);this._toolbar.detachEvent('onselectstart',this._cancelEvent);var $enum1=this._buttons.getEnumerator();while($enum1.moveNext()){var $0=$enum1.get_current();$0.dispose();}}}Microsoft.Mtps.Rendering.Behaviors.Ajax.InlineEditor.createClass('Microsoft.Mtps.Rendering.Behaviors.Ajax.InlineEditor',Sys.UI.Behavior);Microsoft.Mtps.Rendering.Behaviors.Ajax.Button.createClass('Microsoft.Mtps.Rendering.Behaviors.Ajax.Button',null,Sys.IDisposable);Microsoft.Mtps.Rendering.Behaviors.Ajax.ImageButton.createClass('Microsoft.Mtps.Rendering.Behaviors.Ajax.ImageButton',Microsoft.Mtps.Rendering.Behaviors.Ajax.Button);Microsoft.Mtps.Rendering.Behaviors.Ajax.Separator.createClass('Microsoft.Mtps.Rendering.Behaviors.Ajax.Separator',Microsoft.Mtps.Rendering.Behaviors.Ajax.Button);Microsoft.Mtps.Rendering.Behaviors.Ajax.TextButton.createClass('Microsoft.Mtps.Rendering.Behaviors.Ajax.TextButton',Microsoft.Mtps.Rendering.Behaviors.Ajax.Button);Microsoft.Mtps.Rendering.Behaviors.Ajax.Toolbar.createClass('Microsoft.Mtps.Rendering.Behaviors.Ajax.Toolbar',null,Sys.IDisposable);// ---- Do not remove this footer ----// Generated using Script# v0.2.2.0 (http://projects.nikhilk.net)