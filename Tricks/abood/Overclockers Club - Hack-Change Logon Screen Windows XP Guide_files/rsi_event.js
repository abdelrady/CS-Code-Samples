rsi_random = new String (Math.random()); rsi_random = rsi_random.substring(2,11);
rsi_url = document.location;
rsi_referrer = document.referrer;
rsi_title = document.title;
var w = window;
if (!w.rsi_account) {
  rsi_account = '';
}
if (!w.rsi_site) {
  rsi_site = '';
}
if (!w.rsi_event) {
  rsi_event = '';
}
rsi_noads = '1';
rsi_js_url  = location.protocol + "//ads.revsci.net/adserver/ako?rsi_random=" + rsi_random;
rsi_js_url += "&rsi_account="     + escape(rsi_account);
rsi_js_url += "&rsi_site="        + escape(rsi_site);
rsi_js_url += "&rsi_event="       + escape(rsi_event);
rsi_js_url += "&rsi_noads="       + escape(rsi_noads);
rsi_js_url += "&rsi_url="         + escape(rsi_url);
rsi_js_url += "&rsi_referrer="    + escape(rsi_referrer);
rsi_js_url += "&rsi_title="       + escape(rsi_title);

document.write("<" + "script language=\"JavaScript\" src=\"" + rsi_js_url + "\"></" + "script>");
