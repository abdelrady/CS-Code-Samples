function track() {
  var isCook, query ,img;

  if(navigator.cookieEnabled) {
    isCook = navigator.cookieEnabled;
  } else { 
    document.cookie="CheckCookie=test; path=/; expires=0;";
    isCook = (document.cookie != "");
  }
  
  query = 'td_cid=' + td_cid + '&typ=js' +
    '&loc=' + escape(window.location) +
    '&ref=' + escape(document.referrer) +
    '&isc=' + isCook +
    '&isj=' + navigator.javaEnabled();
  if( td_uid ) {
    query += '&td_uid=' + td_uid;
  }
  if(window.screen) {
    query += '&scw=' + screen.width +
      '&sch=' + screen.height +
      '&scc=' + screen.colorDepth;
  }
  
  img = '<img src="' + td_proto + '://demo.trackdealer.jp/a?' + query + '" border=0 width=1 height=1>';
  document.write(img);
}
track();
