var url_id=context_id="";var rm_host=rm_creative_id=rm_section_id=rm_section_code=rm_site_id=rm_site_code=rm_network_id=rm_publisher_code="";var rm_entity_id=rm_banned_pop_types=rm_invalid_media_types=rm_pub_redirect=rm_click_url="";var rm_promote_sizes=rm_promote_sizes_110=rm_promote_sizes_46="";var rm_prepopped_width=rm_prepopped_height=rm_pub_redirect_dont_encode="";var rm_debug_tag=rm_dummy_mode=rm_show_detail=rm_image_tags=rm_iframe_tags_raw=rm_iframe_w=rm_iframe_h="";var rm_customkeys=rm_ignore_freqcap=rm_ban_flash=rm_nopopblocking="";var rm_pop_times=1;var rm_pop_frequency=0;var rm_shrinkage=0;var RM_COOKIE_NAME='ym_pop_freq';if(!rm_host){rm_host="http://ad.yieldmanager.com";}if(!window.rm_invalid_media_types){var rm_invalid_media_types=0;}var flash_version=0;if(flashIntalledCookieExists()){flash_version=flashIntalledCookieExists();}else{var flash=new Object();flash=flashDetection();if(flash.installed==true){writeFlashInstalledCookie(flash.version);flash_version=flash.version;}else{writeFlashInstalledCookie(0);}}function rmAddKey(key,value){rm_customkeys+="&"+key+"="+value;}function rmAddCustomKey(value){rm_customkeys+="&"+value;}function rmShowAd(size){var bad_reason;var original_size=size;var rm_ad_size=rmGetSize(size);if(rm_ad_size<0){document.write('bad ad tag: invalid size');return;}else if(!rm_section_id&&!rm_section_code&&!rm_publisher_code){document.write('bad ad tag: no section_id, section_code, or publisher_code');return;}if(size.indexOf("/")>-1){var sizes=size.split("/");size=sizes[sizes.length-1];}var rm_size_arr=size.split("x");var rm_w=rm_size_arr[0];var rm_h=rm_size_arr[1];rm_url=rm_host+"/imp?z="+rm_ad_size+"&Z="+rm_w+"x"+rm_h;rm_url+=rmGetQueryParameters(original_size);rm_url+=rm_customkeys;if(rm_iframe_tags_raw){rm_tag_src='<IFRAME FRAMEBORDER=0 MARGINWIDTH=0 MARGINHEIGHT=0 SCROLLING=NO WIDTH='+rm_w+' HEIGHT='+rm_h+' SRC="'+rm_url+'"><\/IFRAME>';}else if(rm_image_tags){rm_image_click_url=rm_host+"/imageclick?z="+rm_ad_size;rm_image_click_url+=rmGetQueryParameters(original_size);rm_tag_src='<A HREF="'+rm_image_click_url+'&rid=[TIMESTAMP]"><IMG WIDTH="'+rm_w+'" HEIGHT="'+rm_h+'" SRC="'+rm_url+'&rid=[TIMESTAMP]" /></A>';}else{rm_tag_src='<SCRIPT TYPE="text/javascript" SRC="'+rm_url+'"><\/SCRIPT>';}if(!rm_debug_tag){document.write(rm_tag_src);}else{rm_tag_src=rmReplace(rm_tag_src,'<','&lt;');rm_tag_src=rmReplace(rm_tag_src,'>','&gt;');document.write(''+rm_tag_src+'');}}function rmShowPop(pop){if(!rm_section_id&&!rm_section_code&&!rm_publisher_code){document.write('bad ad tag: no section_id, section_code, or publisher_code');return;}rm_iframe_tags_raw=false;if(rm_pop_frequency){var pop_id='';if(rm_section_id){pop_id=rm_section_id;}else if(rm_section_code){pop_id=rm_section_code;}else if(rm_publisher_code){pop_id=rm_publisher_code;}if(!rm_ignore_freqcap){if(!rmCanShowPop(pop_id,rm_pop_times,rm_pop_frequency)){if(rm_debug_tag)document.write('frequency cap exceeded');return;}}}rm_url=rm_host+"/imp?z=0&Z=0x0";rm_url+=rmGetQueryParameters();rm_url+=rm_customkeys;if(rm_banned_pop_types){rm_url+="&y="+rm_banned_pop_types;}if(rm_prepopped_width){rm_url+="&w="+rm_prepopped_width;}if(rm_prepopped_height){rm_url+="&h="+rm_prepopped_height;}if(rm_nopopblocking){rm_url+="&b=1";}rm_tag_src='<SCRIPT TYPE="text/javascript" SRC="'+rm_url+'"><\/SCRIPT>';if(!rm_debug_tag){document.write(rm_tag_src);}else{rm_tag_src=rmReplace(rm_tag_src,'<','&lt;');rm_tag_src=rmReplace(rm_tag_src,'>','&gt;');document.write(''+rm_tag_src+'');}}function rmShowInterstitial(){rm_url=rm_host+"/imp?z=0";rm_url+=rmGetQueryParameters();rm_url+=rm_customkeys;rm_url+="&w=800&h=620&k=1&y=15";rm_tag_src='<SCRIPT TYPE="text/javascript" SRC="'+rm_url+'"><\/SCRIPT>';if(!rm_debug_tag){document.write(rm_tag_src);}else{rm_tag_src=rmReplace(rm_tag_src,'<','&lt;');rm_tag_src=rmReplace(rm_tag_src,'>','&gt;');document.write(''+rm_tag_src+'');}}function rmGetQueryParameters(size){var rm_url='';if(rm_network_id){rm_url+="&n="+rm_network_id;if(rm_publisher_code){rm_url+="&E="+rm_publisher_code;}if(rm_site_code){rm_url+="&I="+rm_site_code;}if(rm_section_code){rm_url+="&S="+rm_section_code;}}else{if(rm_entity_id){rm_url+="&e="+rm_entity_id;}if(rm_publisher_code){rm_url+="&E="+rm_publisher_code;}if(rm_site_id){rm_url+="&i="+rm_site_id;}else if(rm_site_code){rm_url+="&I="+rm_site_code;}if(rm_section_id){rm_url+="&s="+rm_section_id;}else{rm_url+="&S="+rm_section_code;}}if(rm_iframe_tags_raw){rm_url+="&t=3";}else if(rm_image_tags){rm_url+="&t=2";}if(rm_promote_sizes){rm_url+="&p=1";}else if(rm_promote_sizes_110&&size=="120x600/160x600"){rm_url+="&p=1";}else if(rm_promote_sizes_46&&size=="468x60/728x90"){rm_url+="&p=1";}if(rm_invalid_media_types){if((flash_version)&&(flash_version==0)){rm_invalid_media_types=rm_invalid_media_types+2;}rm_url+="&m="+rm_invalid_media_types;}else if(flash_version==0){rm_url+="&m=2";}else if(rm_ban_flash){rm_url+="&m=23";}if(rm_dummy_mode){rm_url+="&d="+rm_dummy_mode;}if(rm_show_detail){rm_url+="&v="+rm_show_detail;}if(rm_pub_redirect){rm_url+="&x="+rmGetPubRedirect(rm_pub_redirect_dont_encode);}if(rm_click_url){rm_url+="&c="+rmGetClickUrl();}if(!rm_debug_tag){rm_url+="&u="+rmGetWindowUrl();if(top==self){rm_url+="&r=1";}else{rm_url+="&r=0";}}return rm_url;}function rmGetSize(size){if(size.indexOf("pop")>-1)return 0;else if(size.indexOf("430x600")>-1)return 53;else if(size.indexOf("300x600")>-1)return 16;else if(size.indexOf("160x600")>-1)return 10;else if(size=="120x600")return 1;else if(size=="300x250")return 2;else if(size=="336x280")return 3;else if(size=="468x60")return 4;else if(size=="550x150")return 5;else if(size.indexOf("728x90")>-1)return 6;else if(size.indexOf("700x300")>-1)return 8;else if(size=="125x125")return 12;else if(size=="234x60")return 13;else if(size=="120x240")return 14;else if(size=="180x150")return 15;else if(size=="100x25")return 17;else if(size=="710x30")return 18;else if(size.indexOf("720x300")>-1)return 19;else if(size=="300x200")return 20;else if(size=="72x50")return 21;else if(size=="125x90")return 22;else if(size=="120x90")return 23;else if(size=="520x31")return 24;else if(size=="300x400")return 25;else if(size=="460x31")return 26;else if(size=="503x140")return 27;else if(size=="250x400")return 28;else if(size=="200x200")return 29;else if(size=="250x250")return 30;else if(size=="468x250")return 31;else if(size=="500x350")return 32;else if(size=="425x600")return 33;else if(size=="140x60")return 34;else if(size=="120x60")return 35;else if(size=="700x700")return 36;else if(size=="140x140")return 37;else if(size=="620x90")return 38;else if(size=="125x300")return 39;else if(size=="420x100")return 40;else if(size=="88x31")return 41;else if(size=="240x400")return 42;else if(size=="120x300")return 43;else if(size=="380x200")return 44;else if(size=="199x70")return 45;else if(size=="199x170")return 46;else if(size=="180x240")return 47;else if(size=="160x90")return 48;else if(size=="230x33")return 49;else if(size=="134x492")return 50;else if(size=="436x600")return 51;else if(size=="600x400")return 52;else if(size=="460x60")return 54;else if(size=="217x126")return 55;else if(size=="260x31")return 56;else if(size=="120x120")return 57;else if(size=="400x600")return 58;else if(size=="278x85")return 59;else if(size=="300x90")return 60;else if(size=="340x30")return 61;else if(size=="768x400")return 62;else if(size=="768x150")return 63;else if(size=="468x400")return 64;else if(size=="180x500")return 65;else if(size=="140x350")return 66;else if(size=="700x600")return 67;else if(size=="209x30")return 68;else if(size=="300x120")return 69;else if(size=="206x278")return 70;else if(size=="110x60")return 71;else if(size=="90x75")return 72;else if(size=="400x400")return 73;else if(size=="129x740")return 74;else if(size=="440x160")return 75;else if(size=="336x250")return 76;else if(size=="160x300")return 77;else if(size=="240x100")return 78;else if(size=="365x100")return 79;else if(size=="728x180")return 80;else if(size=="600x250")return 81;else if(size=="400x300")return 82;else if(size=="240x600")return 83;else if(size=="320x600")return 84;else if(size=="160x120")return 85;else return-1;}function rmGetWindowUrl(){var url='';try{if(top==self){url=encodeURIComponent(top.location.href);}else{url=encodeURIComponent(document.referrer);}url=url.substr(0,256);}catch(e){}return url;}function rmGetPubRedirect(add_dollar){var url=rm_pub_redirect;if(add_dollar==0){return encodeURIComponent(url);}else{return encodeURIComponent(url+'$');}}function rmGetClickUrl(){var url=rm_click_url;return encodeURIComponent(url);}function rmReplace(myString,toReplace,replaceBy){return(myString.replace(new RegExp(toReplace,'gi'),replaceBy));}function rmTrim(str){if(str!=null)return str.replace(/^\s+/,'').replace(/\s+$/,'');}function rmUrlEncode(txt){var SAFECHARS="0123456789"+"ABCDEFGHIJKLMNOPQRSTUVWXYZ"+"abcdefghijklmnopqrstuvwxyz"+"-_.!~*'()";var HEX="0123456789ABCDEF";var plaintext=txt;var encoded="";for(var i=0;i<plaintext.length;i++){var ch=plaintext.charAt(i);if(ch==" "){encoded+="+";}else if(SAFECHARS.indexOf(ch)!=-1){encoded+=ch;}else{var charCode=ch.charCodeAt(0);if(charCode>255){encoded+="+";}else{encoded+="%";encoded+=HEX.charAt((charCode>>4)&0xF);encoded+=HEX.charAt(charCode&0xF);}}}return encoded;};function rmCanShowPop(section_id,pop_times,pop_frequency){var countCookieName=RM_COOKIE_NAME+section_id;var expireCookieName=RM_COOKIE_NAME+"_expiration"+section_id;var shownTimes=rmGetCookie(countCookieName);if(shownTimes==null){rmWritePopExpirationCookie(section_id,pop_frequency);shownTimes=0;}if(shownTimes<pop_times){shownTimes=1+Number(shownTimes);var expiration=rmGetCookie(expireCookieName);if(navigator.userAgent.indexOf("Safari")!=-1){var expires=new Date();expires.setTime(rmGetCookie(expireCookieName));expiration=expires.toGMTString();}rmWritePopFrequencyCookie(section_id,shownTimes,pop_frequency,expiration);return_value=true;}else{return_value=false;}return return_value;}function rmCookieExists(section_id){var cookieName=RM_COOKIE_NAME+section_id;if(rmGetCookie(cookieName)==null){return false;}else{return true;}}function rmWritePopFrequencyCookie(section_id,pop_times,pop_frequency,expiration){var cookieName=RM_COOKIE_NAME+section_id;var cookieText=cookieName+"="+pop_times+";"+"expires="+expiration+";path=/;";document.cookie=cookieText;return null;}function rmWritePopExpirationCookie(section_id,pop_frequency){var cookieName=RM_COOKIE_NAME+"_expiration"+section_id;var today=new Date();var expires=new Date();expires.setTime(today.getTime()+(1000*pop_frequency));var expiration=expires.toGMTString();if(navigator.userAgent.indexOf("Safari")!=-1){expiration=expires.getTime();}var cookieText=cookieName+"="+expiration+";"+"expires="+expires.toGMTString()+";path=/;";document.cookie=cookieText;return null;}function flashIntalledCookieExists(){var cookieName="flashInstalled";if(rmGetCookie(cookieName)==null){return false;}else{return rmGetCookie(cookieName);}}function writeFlashInstalledCookie(version){var cookieName="flashInstalled";var numdays=14;var today=new Date();var expires=new Date();expires.setTime(today.getTime()+(1000*60*60*24*numdays));var cookieText=cookieName+"="+version+";expires="+expires.toGMTString()+";path=/;";document.cookie=cookieText;return null;}function flashDetection(){var flash=new Object();flash.installed=false;flash.version='0.0';if(navigator.plugins&&navigator.plugins.length){for(x=0;x<navigator.plugins.length;x++){if(navigator.plugins[x].name.indexOf('Shockwave Flash')!=-1){flash.version=navigator.plugins[x].description.split('Shockwave Flash ')[1];flash.installed=true;break;}}}else if(window.ActiveXObject){for(x=2;x<10;x++){try{oFlash=eval("new ActiveXObject('ShockwaveFlash.ShockwaveFlash."+x+"');");if(oFlash){flash.installed=true;flash.version=x+'.0';}}catch(e){}}}return flash;}function rmGetCookie(Name){var search=Name+"=";var CookieString=document.cookie;var result=null;if(CookieString.length>0){offset=CookieString.indexOf(search);if(offset!=-1){offset+=search.length;end=CookieString.indexOf(";",offset);if(end==-1){end=CookieString.length;}result=unescape(CookieString.substring(offset,end));}}return result;}
