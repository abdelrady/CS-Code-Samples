// Clear pre-defined text from text box
function clearTextBox(textbox, str) {
	if (textbox.value == str) textbox.value = "";
}

// Return box to default text if its left blank
function refillTextBox(textbox, str) {
	if (textbox.value == "") textbox.value = str;
}

function addLoadEvent(_function) {
	var _onload = window.onload;
	if ( typeof window.onload != 'function' ) {
		if ( window.onload ) {
			window.onload = _function;
		} else {
			var _addEventListener = window.addEventListener || document.addEventListener;
			var _attachEvent = window.attachEvent || document.attachEvent;
			if ( _addEventListener ) {
				_addEventListener('load', _function, true);
				return true;
			} else if ( _attachEvent ) {
				var _result = _attachEvent('onload', _function);
				return _result;
			} else {
				return false;
			}	
		}
	} else {
		window.onload = function() {
			_onload();
			_function();
		}
	}
}