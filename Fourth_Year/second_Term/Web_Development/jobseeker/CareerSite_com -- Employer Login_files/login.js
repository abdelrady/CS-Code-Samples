function doSubmit(formObj, requiredfields){
	if(checkCookie()){ 
		if(validateAll(formObj, requiredfields)){ 
			return true;
		} 
		else { 
			return false;
		}
	} 
	else {
		alert("Please enable cookies in your browser to continue.");
		return false;
	}
} 

