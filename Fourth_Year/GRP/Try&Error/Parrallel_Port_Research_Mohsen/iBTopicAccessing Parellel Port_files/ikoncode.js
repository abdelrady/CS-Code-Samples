// Javascript Code
// Written by Matthew Mecham unless otherwise stated.
// Rewritten by KEVaholic00
// Copyright (c) 2004 Ikonboard.com
// <http://www.ikonboard.com>

var ie = navigator.appName == 'Microsoft Internet Explorer' ? 1 : 0;
var ns = navigator.appName == 'Netscape' ? 1 : 0;

// Start the subroutines.

var Quote = 0;
var Bold = 0;
var Italic = 0;
var Underline = 0;
var Code = 0;

// IBC Code stuff
var text_enter_url      = "Enter the complete URL for the hyperlink";
var text_enter_url_name = "Enter the title of the webpage";
var text_enter_image    = "Enter the complete URL for the image";
var text_enter_email    = "Enter the email address";
var text_enter_flash    = "Enter the URL to the Flash movie.";
var text_flash_width    = "Enter the Width of the movie in pixels. Maximum Width= ";
var text_flash_height   = "Enter the Height of the movie in pixels. Maximum Height= ";
var text_code           = "Usage: [CODE] Your Code Here.. [/CODE]";
var text_quote          = "Usage: [QUOTE] Your Quote Here.. [/QUOTE]";

// Error stuff

var error_no_url        = "You must enter a URL";
var error_no_title      = "You must enter a title";
var error_no_email      = "You must enter an email address";
var error_no_width      = "You must enter a width";
var error_no_height     = "You must enter a height";
var error_not_url       = "The text you have selected was not recognized as an acceptable URL";
var error_invalid_email = "The text you have selected was not recognized as an acceptable email address";

function IBCurl(type) {
    document.REPLIER.Post.focus();
    if (ie) {
        var enterURL = '', enterTITLE = '', FoundErrors = '';
        var rng = document.selection.createRange();
        if (type == 1) {
            if (rng.text == "") {
                enterURL   = prompt(text_enter_url, "http://");
                enterTITLE = '';
                if (!enterURL) {
                    FoundErrors += "\n" + error_no_url;
                }
            } else {
                enterURL = rng.text;
                if (enterURL.indexOf('http://') != 0) {
                    FoundErrors += "\n" + error_not_url;
                }
            }
            if (FoundErrors) {
                alert("Error!" + FoundErrors);
                return;
            }
            rng.text = "[URL]" + enterURL + "[/URL]";
            document.REPLIER.Post.focus();
        } else {
            if (rng.text == "") {
                enterURL   = prompt(text_enter_url, "http://");
                enterTITLE = prompt(text_enter_url_name, "My Webpage");
                if (!enterURL) {
                    FoundErrors += "\n" + error_no_url;
                }
            } else {
                if (rng.text.indexOf('http://') == 0) {
                    enterURL   = rng.text;
                    enterTITLE = prompt(text_enter_url_name, "My Webpage");
                } else {
                    enterURL   = prompt(text_enter_url, "http://");
                    enterTITLE = rng.text;
                }
            }
            rng.text = "[URL=" + enterURL + "]" + enterTITLE + "[/URL]";
            document.REPLIER.Post.focus();
        }
    } else if (ns) {
        var enterURL = '', enterTITLE = '', FoundErrors = '';
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (type == 1) {
            if (text == "") {
                enterURL   = prompt(text_enter_url, "http://");
                enterTITLE = '';
                if (!enterURL) {
                    FoundErrors += "\n" + error_no_url;
                }
            } else {
                enterURL = text;
                if (enterURL.indexOf('http://') != 0) {
                    FoundErrors += "\n" + error_not_url;
                }
            }
            if (FoundErrors) {
                alert("Error!" + FoundErrors);
                return;
            }
            //document.REPLIER.Post.value.substring(selStart, selEnd) = "[URL]" + enterURL + "[/URL]";
            var before = document.REPLIER.Post.value.substring(0, selStart);
            var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
            document.REPLIER.Post.value = before + "[URL]" + enterURL + "[/URL]" + after;
            document.REPLIER.Post.focus();
        } else {
            if (text == "") {
                enterURL   = prompt(text_enter_url, "http://");
                enterTITLE = prompt(text_enter_url_name, "My Webpage");
                if (!enterURL) {
                    FoundErrors += "\n" + error_no_url;
                }
            } else {
                if (text.indexOf('http://') == 0) {
                    enterURL   = text;
                    enterTITLE = prompt(text_enter_url_name, "My Webpage");
                } else {
                    enterURL   = prompt(text_enter_url, "http://");
                    enterTITLE = text;
                }
            }
            if (!enterTITLE) enterTITLE = enterURL;
            //document.REPLIER.Post.value.substring(selStart, selEnd) = "[URL=" + enterURL + "]" + enterTITLE + "[/URL]";
            var before = document.REPLIER.Post.value.substring(0, selStart);
            var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
            document.REPLIER.Post.value = before + "[URL=" + enterURL + "]" + enterTITLE + "[/URL]" + after;
            document.REPLIER.Post.focus();
        }
    } else {
        return IBCurl_old();
    }
}

function IBCurl_old() {
	document.REPLIER.Post.focus();
    var FoundErrors = '';
    var enterURL   = prompt(text_enter_url, "http://");
    var enterTITLE = prompt(text_enter_url_name, "My Webpage");
    if (!enterURL)    {
        FoundErrors += "\n" + error_no_url;
    }
    if (!enterTITLE)  {
        FoundErrors += "\n" + error_no_title;
    }
    if (FoundErrors)  {
        alert("Error!" + FoundErrors);
        return;
    }
    var ToAdd = "[URL=" + enterURL + "]" + enterTITLE + "[/URL]";
    document.REPLIER.Post.value += ToAdd;
	document.REPLIER.Post.focus();
}

function IBCimage() {
    document.REPLIER.Post.focus();
    if (ie) {
        var enterURL = '', FoundErrors = '';
        var rng = document.selection.createRange();
        if (rng.text == "") {
            enterURL    = prompt(text_enter_image, "http://");
            if (!enterURL) {
                FoundErrors += "\n" + error_no_url;
            }
        } else {
            if (rng.text.indexOf('http://') == 0) {
                enterURL    = rng.text;
            } else {
                FoundErrors += "\n" + error_not_url;
            }
        }
        if (FoundErrors) {
            alert("Error!" + FoundErrors);
            return;
        }
        rng.text = "[IMG]" + enterURL + "[/IMG]";
        document.REPLIER.Post.focus();
    } else if (ns) {
        var enterURL = '', FoundErrors = '';
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            enterURL    = prompt(text_enter_image, "http://");
            if (!enterURL) {
                FoundErrors += "\n" + error_no_url;
            }
        } else {
            if (text.indexOf('http://') == 0) {
                enterURL    = text;
            } else {
                FoundErrors += "\n" + error_not_url;
            }
        }
        if (FoundErrors) {
            alert("Error!" + FoundErrors);
            return;
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = "[IMG]" + enterURL + "[/IMG]";
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + "[IMG]" + enterURL + "[/IMG]" + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCimage_old();
    }
}

function IBCimage_old() {
	document.REPLIER.Post.focus();
    var FoundErrors = '';
    var enterURL   = prompt(text_enter_image, "http://");
    if (!enterURL) {
        FoundErrors += "\n" + error_no_url;
    }
    if (FoundErrors) {
        alert("Error!" + FoundErrors);
        return;
    }
    var ToAdd = "[IMG]" + enterURL + "[/IMG]";
    document.REPLIER.Post.value += ToAdd;
	document.REPLIER.Post.focus();
}

function IBCemail() {
    document.REPLIER.Post.focus();
    if (ie) {
        var emailAddress = '';
        var rng = document.selection.createRange();
        if (rng.text == "") {
            emailAddress = prompt(text_enter_email, "");
            if (!emailAddress) {
                alert(error_no_email);
                return;
            }
        } else {
            if (rng.text.indexOf('@') != -1) {
                emailAddress = rng.text;
            } else {
                alert(error_invalid_email);
                return;
            }
        }
        rng.text = "[EMAIL]" + emailAddress + "[/EMAIL]";
        document.REPLIER.Post.focus();
    } else if (ns) {
        var emailAddress = '';
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            emailAddress = prompt(text_enter_email, "");
            if (!emailAddress) {
                alert(error_no_email);
                return;
            }
        } else {
            if (text.indexOf('@') != -1) {
                emailAddress = text;
            } else {
                alert(error_invalid_email);
                return;
            }
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = "[EMAIL]" + emailAddress + "[/EMAIL]";
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + "[EMAIL]" + emailAddress + "[/EMAIL]" + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCemail_old();
    }
}

function IBCemail_old() {
    document.REPLIER.Post.focus();
    var emailAddress = prompt(text_enter_email,"");
    if (!emailAddress) { alert(error_no_email); return; }
    var ToAdd = "[EMAIL]" + emailAddress + "[/EMAIL]";
    document.REPLIER.Post.value += ToAdd;
    document.REPLIER.Post.focus();
}

function IBCflash(maxWidth, maxHeight) {
    document.REPLIER.Post.focus();
    if (ie) {
        var FoundErrors = '', FlashURL = '', FlashWidth = '', FlashHeight = '';
        var rng = document.selection.createRange();
        if (rng.text == "") {
            FlashURL = prompt(text_enter_flash, "http://");
        } else {
            FlashURL = rng.text;
        }
        FlashWidth  = prompt(text_flash_width  + " " + maxWidth , "");
        FlashHeight = prompt(text_flash_height + " " + maxHeight, "");
        if (!FlashURL) {
            FoundErrors += "\n" + error_no_url;
        }
        if (!FlashWidth) {
            FoundErrors += "\n" + error_no_width;
        }
        if (!FlashHeight) {
            FoundErrors += "\n" + error_no_height;
        }
        if (FoundErrors) {
            alert("Error!" + FoundErrors);
            return;
        }
        rng.text = "[FLASH=" + FlashWidth + "," + FlashHeight + "]" + FlashURL + "[/FLASH]";
        document.REPLIER.Post.focus();
    } else if (ns) {
        var FoundErrors = '', FlashURL = '', FlashWidth = '', FlashHeight = '';
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            FlashURL = prompt(text_enter_flash, "http://");
        } else {
            FlashURL = text;
        }
        FlashWidth  = prompt(text_flash_width  + " " + maxWidth , "");
        FlashHeight = prompt(text_flash_height + " " + maxHeight, "");
        if (!FlashURL) {
            FoundErrors += "\n" + error_no_url;
        }
        if (!FlashWidth) {
            FoundErrors += "\n" + error_no_width;
        }
        if (!FlashHeight) {
            FoundErrors += "\n" + error_no_height;
        }
        if (FoundErrors) {
            alert("Error!" + FoundErrors);
            return;
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = "[FLASH=" + FlashWidth + "," + FlashHeight + "]" + FlashURL + "[/FLASH]";
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + "[FLASH=" + FlashWidth + "," + FlashHeight + "]" + FlashURL + "[/FLASH]" + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCflash_old(maxWidth, maxHeight);
    }
}

function IBCflash_old(maxWidth, maxHeight) {
    document.REPLIER.Post.focus();
    var FoundErrors = '';
    var FlashURL    = prompt(text_enter_flash, "http://");
    var FlashWidth  = prompt(text_flash_width + " " + maxWidth, "");
    var FlashHeight = prompt(text_flash_height + " " + maxHeight, "");
    if (!FlashURL)    {
        FoundErrors += "\n" + error_no_url;
    }
    if (!FlashWidth)  {
        FoundErrors += "\n" + error_no_width;
    }
    if (!FlashHeight) {
        FoundErrors += "\n" + error_no_height;
    }
    if (FoundErrors)  {
        alert("Error!" + FoundErrors);
        return;
    }
    var ToAdd = "[FLASH=" + FlashWidth + "," + FlashHeight +"]" + FlashURL + "[/FLASH]";
    document.REPLIER.Post.value += ToAdd;
    document.REPLIER.Post.focus();
}

function IBCcode() {
    document.REPLIER.Post.focus();
    if (ie) {
        var rng   = document.selection.createRange();
        var ToAdd = '';
        if (rng.text == "") {
            if (Code == 0) {
                ToAdd = "[CODE]";
                document.REPLIER.code.value = " Code*";
                Code = 1;
            } else {
                ToAdd = "[/CODE]";
                document.REPLIER.code.value = " Code ";
                Code = 0;
            }
        } else {
            ToAdd = "[CODE]" + rng.text + "[/CODE]";
        }
        rng.text = ToAdd;
        document.REPLIER.Post.focus();
    } else if (ns) {
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            if (Code == 0) {
                ToAdd = "[CODE]";
                document.REPLIER.code.value = " Code*";
                Code = 1;
            } else {
                ToAdd = "[/CODE]";
                document.REPLIER.code.value = " Code ";
                Code = 0;
            }
        } else {
            ToAdd = "[CODE]" + text + "[/CODE]";
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = ToAdd;
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + ToAdd + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCcode_old();
    }
}

function IBCcode_old() {
    document.REPLIER.Post.focus();
    if (Code == 0) {
       ToAdd = "[CODE]";
       document.REPLIER.code.value = " Code*";
       Code = 1;
    } else {
       ToAdd = "[/CODE]";
       document.REPLIER.code.value = " Code ";
       Code = 0;
    }
    document.REPLIER.Post.value += ToAdd;
    document.REPLIER.Post.focus();
}

function IBCquote() {
    document.REPLIER.Post.focus();
    if (ie) {
        var rng   = document.selection.createRange();
        var ToAdd = '';
        if (rng.text == "") {
            if (Quote == 0) {
                ToAdd = "[QUOTE]";
                document.REPLIER.quote.value = " Quote*";
                Quote = 1;
            } else {
                ToAdd = "[/QUOTE]";
                document.REPLIER.quote.value = " Quote ";
                Quote = 0;
            }
        } else {
            ToAdd = "[QUOTE]" + rng.text + "[/QUOTE]";
        }
        rng.text = ToAdd;
        document.REPLIER.Post.focus();
    } else if (ns) {
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            if (Quote == 0) {
                ToAdd = "[QUOTE]";
                document.REPLIER.quote.value = " Quote*";
                Quote = 1;
            } else {
                ToAdd = "[/QUOTE]";
                document.REPLIER.quote.value = " Quote ";
                Quote = 0;
            }
        } else {
            ToAdd = "[QUOTE]" + text + "[/QUOTE]";
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = ToAdd;
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + ToAdd + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCquote_old();
    }
}

function IBCquote_old() {
    document.REPLIER.Post.focus();
    if (Quote == 0) {
       ToAdd = "[QUOTE]";
       document.REPLIER.quote.value = " Quote*";
       Quote = 1;
    } else {
       ToAdd = "[/QUOTE]";
       document.REPLIER.quote.value = " Quote ";
       Quote = 0;
    }
    document.REPLIER.Post.value += ToAdd;
    document.REPLIER.Post.focus();
}

function IBCbold() {
    document.REPLIER.Post.focus();
    if (ie) {
        var rng = document.selection.createRange();
        var ToAdd = '';
        if (rng.text == "") {
            if (Bold == 0) {
                ToAdd = "[B]";
                document.REPLIER.bold.value = " B*";
                Bold = 1;
            } else {
                ToAdd = "[/B]";
                document.REPLIER.bold.value = " B ";
                Bold = 0;
            }
        } else {
            ToAdd = "[B]" + rng.text + "[/B]";
        }
        rng.text = ToAdd;
        document.REPLIER.Post.focus();
    } else if (ns) {
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            if (Bold == 0) {
                ToAdd = "[B]";
                document.REPLIER.bold.value = " B*";
                Bold = 1;
            } else {
                ToAdd = "[/B]";
                document.REPLIER.bold.value = " B ";
                Bold = 0;
            }
        } else {
            ToAdd = "[B]" + text + "[/B]";
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = ToAdd;
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + ToAdd + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCbold_old();
    }
}

function IBCbold_old() {
    document.REPLIER.Post.focus();
    if (Bold == 0) {
       ToAdd = "[B]";
       document.REPLIER.bold.value = " B*";
       Bold = 1;
    } else {
       ToAdd = "[/B]";
       document.REPLIER.bold.value = " B ";
       Bold = 0;
    }
    document.REPLIER.Post.value += ToAdd;
    document.REPLIER.Post.focus();
}

function IBCitalic() {
    document.REPLIER.Post.focus();
    if (ie) {
        var rng = document.selection.createRange();
        var ToAdd = '';
        if (rng.text == "") {
            if (Italic == 0) {
                ToAdd = "[I]";
                document.REPLIER.italic.value = " I*";
                Italic = 1;
            } else {
                ToAdd = "[/I]";
                document.REPLIER.italic.value = " I ";
                Italic = 0;
            }
        } else {
            ToAdd = "[I]" + rng.text + "[/I]";
        }
        rng.text = ToAdd;
        document.REPLIER.Post.focus();
    } else if (ns) {
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            if (Italic == 0) {
                ToAdd = "[I]";
                document.REPLIER.italic.value = " I*";
                Italic = 1;
            } else {
                ToAdd = "[/I]";
                document.REPLIER.italic.value = " I ";
                Italic = 0;
            }
        } else {
            ToAdd = "[I]" + text + "[/I]";
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = ToAdd;
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + ToAdd + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCitalic_old();
    }
}

function IBCitalic_old() {
    document.REPLIER.Post.focus();
    if (Italic == 0) {
       ToAdd = "[I]";
       document.REPLIER.italic.value = " I*";
       Italic = 1;
    } else {
       ToAdd = "[/I]";
       document.REPLIER.italic.value = " I ";
       Italic = 0;
    }
    document.REPLIER.Post.value += ToAdd;
    document.REPLIER.Post.focus();
}

function IBCunder() {
    document.REPLIER.Post.focus();
    if (ie) {
        var rng = document.selection.createRange();
        var ToAdd = '';
        if (rng.text == "") {
            if (Underline == 0) {
                ToAdd = "[U]";
                document.REPLIER.under.value = " U*";
                Underline = 1;
            } else {
                ToAdd = "[/U]";
                document.REPLIER.under.value = " U ";
                Underline = 0;
            }
        } else {
            ToAdd = "[U]" + rng.text + "[/U]";
        }
        rng.text = ToAdd;
        document.REPLIER.Post.focus();
    } else if (ns) {
        var selStart = document.REPLIER.Post.selectionStart;
        var selEnd   = document.REPLIER.Post.selectionEnd;
        var text     = document.REPLIER.Post.value.substring(selStart, selEnd);
        if (text == "") {
            if (Underline == 0) {
                ToAdd = "[U]";
                document.REPLIER.under.value = " U*";
                Underline = 1;
            } else {
                ToAdd = "[/U]";
                document.REPLIER.under.value = " U ";
                Underline = 0;
            }
        } else {
            ToAdd = "[U]" + text + "[/U]";
        }
        //document.REPLIER.Post.value.substring(selStart, selEnd) = ToAdd;
        var before = document.REPLIER.Post.value.substring(0, selStart);
        var after  = document.REPLIER.Post.value.substring(selEnd, document.REPLIER.Post.textLength);
        document.REPLIER.Post.value = before + ToAdd + after;
        document.REPLIER.Post.focus();
    } else {
        return IBCunder_old();
    }
}

function IBCunder_old() {
    document.REPLIER.Post.focus();
    if (Underline == 0) {
       ToAdd = "[U]";
       document.REPLIER.under.value = " U*";
       Underline = 1;
    } else {
       ToAdd = "[/U]";
       document.REPLIER.under.value = " U ";
       Underline = 0;
    }
    document.REPLIER.Post.value += ToAdd;
    document.REPLIER.Post.focus();
}