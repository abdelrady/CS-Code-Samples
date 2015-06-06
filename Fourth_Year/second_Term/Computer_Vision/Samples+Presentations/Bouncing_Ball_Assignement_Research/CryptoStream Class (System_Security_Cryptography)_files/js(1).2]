Type.registerNamespace('Microsoft.Mtps.Web.WebServices');
Microsoft.Mtps.Web.WebServices.TagCompletionWebService=function() {
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.initializeBase(this);
this._timeout = 0;
this._userContext = null;
this._succeeded = null;
this._failed = null;
}
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.prototype={
_get_path:function() {
 var p = this.get_path();
 if (p) return p;
 else return Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.get_path();},
GetTagCompletionList:function(prefixText,count,contextKey,succeededCallback, failedCallback, userContext) {
return this._invoke(this._get_path(), 'GetTagCompletionList',false,{prefixText:prefixText,count:count,contextKey:contextKey},succeededCallback,failedCallback,userContext); }}
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.registerClass('Microsoft.Mtps.Web.WebServices.TagCompletionWebService',Sys.Net.WebServiceProxy);
Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance = new Microsoft.Mtps.Web.WebServices.TagCompletionWebService();
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.set_path = function(value) { Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.set_path(value); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.get_path = function() { return Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.get_path(); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.set_timeout = function(value) { Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.set_timeout(value); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.get_timeout = function() { return Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.get_timeout(); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.set_defaultUserContext = function(value) { Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.set_defaultUserContext(value); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.get_defaultUserContext = function() { return Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.get_defaultUserContext(); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.set_defaultSucceededCallback = function(value) { Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.set_defaultSucceededCallback(value); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.get_defaultSucceededCallback = function() { return Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.get_defaultSucceededCallback(); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.set_defaultFailedCallback = function(value) { Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.set_defaultFailedCallback(value); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.get_defaultFailedCallback = function() { return Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.get_defaultFailedCallback(); }
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.set_path("/Platform/Controls/TagEditor/TagCompletionWebService.asmx");
Microsoft.Mtps.Web.WebServices.TagCompletionWebService.GetTagCompletionList= function(prefixText,count,contextKey,onSuccess,onFailed,userContext) {Microsoft.Mtps.Web.WebServices.TagCompletionWebService._staticInstance.GetTagCompletionList(prefixText,count,contextKey,onSuccess,onFailed,userContext); }
