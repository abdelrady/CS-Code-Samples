// -----------------------------------------
//               tagStrip
// Strips tags of a specified out of an HTML
// string.
// Returns string minus it's tags
// -----------------------------------------
//if mode != 'all' strip just the tags
//if mode == 'all' strip the tags and the text between them
function tagStrip(rmvtags, instr, mode) {
    var striptags = rmvtags.split(":");
	retVal = instr;
	
	for (tag in striptags) {
		if (mode == 'all') {
			retVal = retVal.replace(eval('/<' + striptags[tag] + '(.|\\s)*?>(.|\\s)*?<\\/' + striptags[tag] + '>/gi'), '');
			}
		else {
			retVal = retVal.replace(eval('/<\\/?' + striptags[tag] + '(.|\\s)*?>/gi'), '');
			}
		}
	
	return retVal;
}

// -----------------------------------------
//               protectedTagStrip
// -----------------------------------------
function protectedTagStrip(instr, isprotected) {
	outstr = instr;

	if (!isprotected) {
		outstr = tagStrip('', outstr, 'none');
	}
	
	return outstr;
}

// -----------------------------------------
//               validateElementComplex
// -----------------------------------------
function validateElementComplex(elem, valType) {
	// 'js_number', 'js_alphanum'
	var errstr = '';
			
	if (elem.type == "text" || elem.type == "textarea" || elem.type == "password") {
		if (valType == 'js_number') {
			if (!validateNumber(elem) && elem.value != '') {
				errstr += '\n' + elem.id + ' must be a number\n';
			}
		}
		if (valType == 'js_alphanum') {
			if (!validateAphanum(elem) && elem.value != '') {
				errstr += '\n' + elem.id + ' can contain only numbers or letters\n';
			}
		}
	}
	
	return errstr;
}

// -----------------------------------------
//               useComplexValidation
// -----------------------------------------
function useComplexValidation(elem, valType) {
	var useComplex = false;
	
	uselist = valType;
	if (document.getElementById(uselist)) {
		usearr = document.getElementById(uselist).value.split(":");
		
		for (fieldid in usearr) {
			if (elem.id == usearr[fieldid]) {
				useComplex = true;
			}
		}
	}
	
	return useComplex;
}

// -----------------------------------------
//               pageJumpMonitor
// Watches if there are any form changes
// on edit|duplicate|repost and dispables
// pageJump links if anything is changed
// -----------------------------------------
function pageJumpMonitor(formObj) {
	for (var i=0; i < (formObj.elements.length -1); i++) {
		//This doesn't work in IE due to how it handles event attributes...
		//setAttributeVal(formObj.elements[i], 'onchange', 'pageJumpDisable();');
		formObj.elements[i].onchange = pageJumpDisable;
	}
}

// -----------------------------------------
//               pageJumpDisable
// Disables the pageJumpNav
// -----------------------------------------
function pageJumpDisable() {
	if (document.getElementById('pageJumpNav')) {
		navblock = document.getElementById('pageJumpNav');
		stripanchors = tagStrip('a', navblock.innerHTML, 'tag');
		navblock.innerHTML = stripanchors;
	}
}


// -----------------------------------------
//                  validateAll
// Validates all form fields.  Checks for empty
// required fields, confirms formatting for
// nonrequired -- phone, email and zip code
// -----------------------------------------
function validateAll(formObj, requiredfieldids) {
	var reqfieldidArr = requiredfieldids.split(':');
	var notvalidatedArr = requiredfieldids.split(':');
	var errstr = '';
	
	//Check to make sure ranges are all correct
	var rangeElement = 'js_range';
	if (document.getElementById(rangeElement)) {
		errstr += validateRangeComplex(document.getElementById(rangeElement).value);
	}
	//Check to make sure dates are all correct
	var dateElement = 'js_date';
	if (document.getElementById(dateElement)) {
		errstr += validateDateComplex(document.getElementById(dateElement).value);
	}
	
	for (var i=0; i < (formObj.elements.length -1); i++) {
        elem = formObj.elements[i];
		isRequired = false;

		if (elem.id) {
			if (arrElementExists(notvalidatedArr, elem.id) != -1) {
				notvalidatedArr = arrElementDelete(notvalidatedArr, elem.id);
				isRequired = true;
			}
		}
        
		//Start Use Complex validation
		//Due to the nature of how js_allowhtml, js_date and js_range are used, they are
		//omitted from this list
		complexValidations = new Array('js_number', 'js_alphanum');
		for (valType in complexValidations) {
			useValidation = useComplexValidation(elem, complexValidations[valType]);
			
			if (useValidation) {
				errstr += validateElementComplex(elem, complexValidations[valType]);
			}
		}
		//End Use Complex Validations
				
		
		if (isRequired) {
			errstr += validateElement(elem, 1);
		}
		else {
			errstr += validateElement(elem, 0);
		}
	}
	if(errstr != "") {
		alert(errstr);
		return false;
	}
	return true;
}

function validateElement(elem, required) {
	var errstr = '';
	
	//for checkboxes and input groups
	var minrequired = 1;
	var maxrequired = 0;
	
	var dupeIdCount = inputIdCount(elem);
	//errstr += elem.id + '/' + elem.name + ' = ' + dupeIdCount + '\n';
	
	if (elem.id && dupeIdCount > 1) {
		var minreqfieldname = elem.id + '_mincheck';
		var maxreqfieldname = elem.id + '_maxcheck';
		if (document.getElementById(maxreqfieldname)) {
		    maxrequired = document.getElementById(maxreqfieldname).value;
		}
		if (document.getElementById(minreqfieldname)) {
		    minrequired = document.getElementById(minreqfieldname).value;
		}
	}
	if (elem.type == "text" || elem.type == "textarea" || elem.type == "password") {
		//Strip the HTML contents of the field
		protectedElem = useComplexValidation(elem, 'js_allowhtml');
		elem.value = protectedTagStrip(elem.value, protectedElem);
		
		if (required) {
			errstr += validateElementGroup(elem, minrequired, maxrequired);
		}
		else {
			errstr += validateFormat(elem);
			//errstr += elem.id + '/' + elem.name + ' = ' + dupeIdCount + '\n';
		}
	}
    if (elem.type.search(/select/gi) != -1) {
        if (required) {
            if ( dupeIdCount > 1) {           
                if (!validateSelectGrp(elem, minrequired, maxrequired)) {
			       errstr += '\nYou must select at least ' + minrequired;
			       if (maxrequired > 0) {
			          errstr += ' and no more than ' + maxrequired;
			       }
			       errstr += ' value(s) for ' + elem.id + '.\n';
			    }
           } else if(!validateSelect(elem)){
                    errstr += "\nPlease select a value for " + elem.id + ".\n";
                    elem.focus();
           }
        }
    }
	if (elem.type == "checkbox") {
		if (required) {
			if (!validateCheckBoxGrp(elem, minrequired, maxrequired)) {
			    errstr += '\nYou must select at least ' + minrequired;
			    if (maxrequired > 0) {
			        errstr += ' and no more than ' + maxrequired;
			    }
			    errstr += ' value(s) for ' + elem.id + '.\n';
			}
		}
					
	}
	return errstr;
}

// -----------------------------------------
//               validateElementGroup
// Validates Groups of form elements that count
// as one Required Field
// -----------------------------------------
function validateElementGroup(elem, emin, emax) {
	fillnum = 0;
	fillmax = true;
	errstr = '';
	dupeIdCount = inputIdCount(elem);
	//errstr += elem.id + ' = ' + dupeIdCount + '\n';

	if (dupeIdCount > 1) {
		for (var i=0; i < (formObj.elements.length -1); i++) {
			if (formObj.elements[i].id == elem.id) {
				myelem = formObj.elements[i];
				//errstr += myelem.name + ' = ' + myelem.value + '\n';
				if (validateBlank(myelem)) {
					errstr += validateFormat(myelem)
					fillnum++;
				}
			}
		}
		
		if (fillnum > emax && emax > 0) {
			fillmax = false;
		}
		
		//logic to determine if a field is checked...
		if (fillnum < emin || !fillmax) {
		    errstr += '\nYou must fill in at least ' + emin;
		    if (emax > 0) {
		        errstr += ' and no more than ' + emax;
		    }
		    errstr += ' value(s) for ' + elem.id + '.\n';
		}
		
	}
	else {
		if(!validateBlank(elem)){
		    errstr += "\n" + elem.id + " cannot be left blank.\n";
		}
		else {
			errstr += validateFormat(elem)
		}
	}
	
	return errstr;
}

// -----------------------------------------
//               validateFormat
// Returns an errstr with problems encountered
// validating the field
// -----------------------------------------
function validateFormat(elem) {
	errstr = '';
	errlabel = '';
	
	if (elem.id) {
		errlabel = elem.id;
	}
	else {
		errlabel = elem.name;
	}
	
	if (trim(elem.value) != '') {
		//errstr += elem.id + '/' + elem.name + ' = ' + dupeIdCount + '\n';

		if (elem.name.search(/zip/gi) > -1) {
			validated = 1;
            if(!validateZIP(elem)){
	            errstr += "\n" + errlabel;
                errstr += " must contain a valid US or Canada zip code.\n";
                elem.focus();
            }
		}
		if (elem.name.search(/fax/gi) > -1) {
			validated = 1;
            if(!validateTelnr(elem)){
	            errstr += "\n" + errlabel;
                errstr += " is not a valid phone number. Characters permitted are digits, space ( ) - and leading + \n";
                elem.focus();
            }
		}
		if (elem.name.search(/phone/gi) > -1) {
			validated = 1;
            if(!validateTelnr(elem)){
	            errstr += "\n" + errlabel;
                errstr += " is not a valid phone number. Characters permitted are digits, space ( ) - and leading + \n";
                elem.focus();
            }
		}
		if (elem.name.search(/email/gi) > -1) {
			validated = 1;
			//this method does not allow multiple email addresses to be listed
			//We are aware of this and it is intentional --seg 29Apr05
		    if(!validateEmail(elem.value)){
	            errstr += "\n" + errlabel;
		        errstr += " is not a valid email address \n";
		        elem.focus();
		    }
		}
	}
	
	return errstr;
}

// ---------------------------------------------------
//            validateRangeComplex
// ---------------------------------------------------
function validateRangeComplex(rangelist){
	var rangeArr = rangelist.split(':');
	var dateRangeExp = new RegExp("date", "gi");
	var yr, mo, dy, floorval, ceilingval;
	var errstr = '';
	
	for (rangepair in rangeArr) {
		pairArr = rangeArr[rangepair].split('_');
		
		if (document.getElementById(pairArr[0]) && document.getElementById(pairArr[1])) {
			floorval = document.getElementById(pairArr[0]).value;
			ceilingval = document.getElementById(pairArr[1]).value;
		}
		else {
			floorval = 'NaN';
			ceilingval = 'NaN';
		}
		
		if (pairArr[0].search(dateRangeExp) != -1) {
			yr = collectDateValue(pairArr[0], 'year');
			mo = collectDateValue(pairArr[0], 'month');
			dy = collectDateValue(pairArr[0], 'day');
			
			floorval = '1' + yr + mo + dy;
		}
		if (pairArr[1].search(dateRangeExp)!= -1) {
			yr = collectDateValue(pairArr[1], 'year');
			mo = collectDateValue(pairArr[1], 'month');
			dy = collectDateValue(pairArr[1], 'day');
			
			ceilingval = '1' + yr + mo + dy;
		}
		
		//alert(dateRangeExp);
		//alert(floorval + '/' + ceilingval);
		if (floorval > 1 && ceilingval > 1 && !validateRange(floorval, ceilingval)) {
			if (document.getElementById(pairArr[1]+" Validation Error Message")) {
				errstr += '\n'+document.getElementById(pairArr[1]+" Validation Error Message").value+'\n';
			} else {
				errstr += '\nThe value for ' + pairArr[0] + ' cannot be after ' + pairArr[1] + '\n';
			}
		}
	}
    
    return errstr;
}

// ---------------------------------------------------
//            validateRange
// ---------------------------------------------------
function validateRange(floorval, ceilingval){
    var floorval = trim(floorval);
    var ceilingval = trim(ceilingval);
    
    floorval = floorval.replace(/\$/, '');
    ceilingval = ceilingval.replace(/\$/, '');
    
    floorval = parseInt(floorval,10);
    ceilingval = parseInt(ceilingval,10);
    
	if (isNaN(floorval)) {
		floorval = 0;
	}
	if (isNaN(ceilingval)) {
		ceilingval = 0;
	}
	if (floorval > ceilingval) {
		return false;
	}
	
	return true;
}

// ---------------------------------------------------
//            collectDateValue
// Grabs the date value from elemets with similar ids
// ---------------------------------------------------
function collectDateValue(dateid, part){
	var datePart = 0;
	var fieldSuffix = '';
	var formObj = document.getElementById(dateid).form;
	var datePartExp = new RegExp(part, "gi");
	
	for (var i=0; i < (formObj.elements.length -1); i++) {
		if (formObj.elements[i].id == dateid && formObj.elements[i].name.search(datePartExp) != -1) {
			if (formObj.elements[i].type.search(/select/gi) != -1) {
				datePart = formObj.elements[i].options[formObj.elements[i].selectedIndex].value;
			}
			else {
				datePart = formObj.elements[i].value;
			}
		}
	}
	
	return datePart;
}

// ---------------------------------------------------
//            validateDateComplex
// ---------------------------------------------------
function validateDateComplex(datelist) {
	var dateArr = datelist.split(':');
	var errstr = '';
	var myDay, myMonth, myYear;
	
	for (elem in dateArr) {
		myDay = collectDateValue(dateArr[elem], 'day');
		myMonth = collectDateValue(dateArr[elem], 'month');
		myYear = collectDateValue(dateArr[elem], 'year');
		
		//alert('validateDateComplex(' + myMonth + ', ' + myDay + ', ' + myYear + ')' );
		//alert(validateDate(myMonth, myDay, myYear));
		if (!validateDate(myMonth, myDay, myYear)) {
			errstr += '\nYou must select a valid date for ' + dateArr[elem] + '\n';
		}
	}
	
	return errstr;
}

// -----------------------------------------
//                  validateDateString
// this function takes a string mon/day/year
// and returns true if vald, false if not.
// Yearmask takes a value of 'yy' or 'yyyy'
// depending on whether you want a 2  or 4
// digit year validated.
// -----------------------------------------
function validateDateString(dtStr, yearmask) {
	var retVal = false;
	var pos1 = dtStr.indexOf('/');
	var pos2 = dtStr.indexOf('/', pos1+1);
	var strMonth = dtStr.substring(0, pos1);
	var strDay = dtStr.substring(pos1+1, pos2);
	var strYear = dtStr.substring(pos2+1);
	
	if (validateDate(strMonth, strDay, strYear)) {
		retVal = true;
	}
	
	if (strYear.length != yearmask.length) {
		retVal = false;
	}
	
	return retVal;
}


// ---------------------------------------------------
//            validateDate
// takes a month/day/year and determines if they're valid
// ---------------------------------------------------
function validateDate(monthval, dayval, yearval) {
	var retVal = false;
	var monthval = parseInt(monthval, 10);
	var dayval = parseInt(dayval, 10);
	var yearval = parseInt(yearval, 10);
	//alert('-' + monthval + '-' + dayval + '-' + yearval);
	
	switch(monthval){
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			retVal = (dayval <= 31);
			break;
		case 4:
		case 6:
		case 11:
		case 9:
			retVal = (dayval <= 30);
			break;
		case 2:
			if(dayval == 29) {
				retVal = ( (((yearval % 4) == 0) && ((yearval % 100 ) != 0)) || (yearval % 400 == 0));
			}
			else {
				retVal = (dayval <= 28 );
			}
			break;
	}
	
	if (dayval < 1) {
		retVal = false;
	}
	if (isNaN(yearval)) {
		retVal = false;
	}
	
	return retVal
}

// -----------------------------------------
//                  cformValidateAll
// This is the cform implementation of
// validateAll
// -----------------------------------------
function cformValidateAll(formObj) {
	errstr = '';
	
	for (var i=0; i < (formObj.elements.length -1); i++) {
        elem = formObj.elements[i];
        
        if (elem.name && elem.name.search(/date/gi) > -1) {
			errstr += cformValidateDate(elem);
		}
	}
	if(errstr != "") {
		alert(errstr);
		return false;
	}
	return true;
}

// -----------------------------------------
//                  cformValidateDate
// This function validates the dates in
// the cform calendar control
// -----------------------------------------
function cformValidateDate(elem) {
	var errstr = '';
	var dateStr = elem.value;
	
	if (!validateDateString(dateStr, 'yyyy') && trim(dateStr) != '') {
		//tried to add this to cforms.js as cocoon.forms.getLabel-- doesn't work there either
		//cformGetLabel(elem);
		elemLabel = cformGetLabel(elem);
		errstr = "\n" + elemLabel + " has not been entered in the correct format.\n";
	}
	
	return errstr;
}


// -----------------------------------------
//                  cformGetLabel
// This function returns the text of the
// the label node associated with elem
// -----------------------------------------
function cformGetLabel(elem) {
	var retVal = '';
	var labelid = elem.name + ':label';
	
	labelObj = document.getElementById(labelid);
	
	if (labelObj) {
		retVal = labelObj.innerHTML;
	}
	
	return retVal;
}


// -----------------------------------------
//                  inputIdCount
// Count the number of elements with the same
// id attribute as this one.
// Yes, yes.  Using id like this does not
// conform to XHTML spec...
// -----------------------------------------
function inputIdCount(elem) {
	inputCount = 0;
	inputID = elem.id;
	formObj = elem.form;
	
	for (var i=0; i < (formObj.elements.length -1); i++) {
		if (formObj.elements[i].id == inputID) {
			inputCount++;
		}
	}
	
	return inputCount;
}

//THIS FUNCTION IS DEPRICATED AND SCHEDULED
//FOR DEMOLITION -- seg 06May05
// -----------------------------------------
//                  validate
// Validates all the required fields
// This is a depricated verson of the function
// -----------------------------------------
function validate(requiredfieldids)
{
    var reqfieldidArr = requiredfieldids.split(":");
    var str="";
    for(var i=0; i<reqfieldidArr.length; i++){
        elem = document.getElementById(reqfieldidArr[i]);
        if(elem != null && elem != undefined && elem != "")
        {
            if(elem.type != "radio"){
                if((elem.id.indexOf("ZIP") > -1) && (elem.type == "text")){
                    if(!validateZIP(elem)){
                        str = str+"\n must contain a valid US or Canada zip code.\n";
                        elem.focus();
                    }
                }
                if((elem.id.indexOf("Phone") > -1) && (elem.type == "text")){
                    if(!validateTelnr(elem)){
                        str = str+"\n Not a valid phone number. Characters permitted are digits, space ( ) - and leading + \n";
                        elem.focus();
                    }
                }
                if((elem.name.indexOf("email") > -1) && (elem.type == "text")){
                    var token;
                    if(elem.value.indexOf(",") > -1 || elem.value.indexOf(";") > -1)
                    {
                        if(elem.value.indexOf(",") > -1)
                            token = elem.value.split(",");
                        if(elem.value.indexOf(";") > -1)
                            token = elem.value.split(";");
                        for(var t=0; t<token.length; t++)
                        {
                            if(!validateEmail(token[t])){
                                str = str+"\n Not a valid email address \n";
                                elem.focus();
                            }
                        }
                    }    
                    else
                    {
                        if(!validateEmail(elem.value)){
                            str = str+"\n Not a valid email address \n";
                            elem.focus();
                        }
                    }
                }
                if(elem.type == "text" || elem.type == "textarea" || elem.type == "password") {
                    if(!validateBlank(elem)){
                        str = str+"\n"+elem.id + " cannot be left blank.\n";
                    }
                }
                if(elem.type.search(/select/gi) != -1){
                    if(!validateSelect(elem)){
                            str = str+"\n Please select a " + elem.id + " value.\n";
                            elem.focus();
                    }
                }
                if (elem.type == "checkbox") {
	                var minrequired = 1;
	                var maxrequired = 0;
	                
	                var maxreqfieldname = elem.id + '_maxcheck';
	                if (document.getElementById(maxreqfieldname)) {
		                maxrequired = document.getElementById(maxreqfieldname).value;
	                }
	                
	                if (!validateCheckBoxGrp(elem, minrequired, maxrequired)) {
		                str += "\nYou must select at least " + minrequired;
		                if (maxrequired > 0) {
			                str += " and no more than " + maxrequired;
		                }
		                str += " value(s) for " + elem.id + ".\n";
	                }
                }
            }
            if(str != "" && i==reqfieldidArr.length-1)
            {
                alert(str);
                return false;
            }
        }
    }
    return true;
}

// ---------------------------------------------------
//            validateZIP
// validate, if the field is Proper ZIP (us format: 12345 or 12345-1234)
// **updated to handle canadian zips (ie: V6Z 1R7) too.  sgilroy 2008Apr02
// ---------------------------------------------------
function validateZIP(elem){
    var elemValue = trim(elem.value);  // value of field with whitespace trimmed off
    var usCanZipRE = /^((\d{5}([- ])\d{4})|(\d{5})|([AaBbCcEeGgHhJjKkLlMmNnPpRrSsTtVvXxYy]\d[A-Za-z]\s?\d[A-Za-z]\d))$/;
    
    if (!usCanZipRE.test(elemValue)) {
        return false;
    }
    return true;
}

// ---------------------------------------------------
//            validateAphanum
// validate, if the field contains only numbers/letters
// ---------------------------------------------------
function validateAphanum(elem){
    var elemValue = trim(elem.value);
    
    var alphanumRE = /^[0-9A-Za-z]+$/
    if (!alphanumRE.test(elemValue)) {
        return false;
    }
    return true;
}

// ---------------------------------------------------
//            validateNumber
// validate, if the field is a Number
// ---------------------------------------------------
function validateNumber(elem){
    elem.value = trim(elem.value);
    var elemValue = elem.value;
    if (isNaN(elemValue)) {
        return false;
    }
    return true;
}

// -----------------------------------------
//            validateBlank
// validate, if the field is blank.
// -----------------------------------------
function validateBlank(elem){
    if(trim(elem.value) == ""){
        elem.value = "";
        return false;
    }
    return true;
}

// -----------------------------------------
//               validateEmail
// Validate if email address
// Returns true if so
// -----------------------------------------
function validateEmail (elem) {
  var elemValue = trim(elem);  // value of field with whitespace trimmed off
  var email = /^[^@]+@[^@.]+\.[^@]*\w\w$/
  var email2 = /^[A-Za-z][\w.-]+@\w[\w.-]+\.[\w.-]*[A-Za-z][A-Za-z]$/
  if (!email.test(elem)) {
      if (!email2.test(elem)) {
         return false;
     }
  }
  return true;
}

// -----------------------------------------
//            validateTelnr
// Validate telephone number
// Returns true if so
// Permits spaces, hyphens, brackets and leading +
// -----------------------------------------
function validateTelnr (elem) {
  var elemValue = trim(elem.value);  // value of field with whitespace trimmed off
  var telnr = /^\+?[0-9 ()-]+[0-9]$/
  if (!telnr.test(elemValue)) {
    return false;
  }
  return true;
}

// -----------------------------------------
//            validateSelect
// validate, if any options are selected
// excluding the default, of course.
// -----------------------------------------
function validateSelect(elem){
	if(elem.type == "select-one"){
		selectedVal = trim(elem.options[elem.selectedIndex].value);
		selectedTxt = trim(elem.options[elem.selectedIndex].text);
		selectSelected = selectedTxt.search(/select/gi);
		if(selectedVal == "" || selectSelected > -1){
			return false;
		}
	}
	if(elem.type == "select-multiple"){
		if(elem.selectedIndex == "-1"){
			return false;
		}
	}
	return true;
}

// -----------------------------------------
//            validateCheckBoxGrp
// validate, if any elements in a series of
// Check Boxes are checked
// -----------------------------------------
function validateCheckBoxGrp(elem, minreq, maxreq){
	checknum = 0;
	checkmax = true;
	formObj = elem.form;
	requiredid = elem.id;
	
	for (var i=0; i < (formObj.elements.length -1); i++) {
		if (formObj.elements[i].id == requiredid && formObj.elements[i].checked == true) {
			checknum++;
		}
	}
		
	if (checknum > maxreq && maxreq > 0) {
		checkmax = false;
	}
	
	//logic to determine if a field is checked...
	if (checknum < minreq || !checkmax) {
		return false;
	}
	return true;
}

// -----------------------------------------
//            validateSelectGrp
// validate, if any elements in a series of
// Selects are selected
// -----------------------------------------
function validateSelectGrp(elem, minreq, maxreq){
	selectnum = 0;
	selectmax = true;
	formObj = elem.form;
	requiredid = elem.id;
	
	for (var i=0; i < (formObj.elements.length -1); i++) {
		if (formObj.elements[i].id == requiredid && formObj.elements[i].value != "") {
			selectnum++;
		}
	}
		
	if (selectnum > maxreq && maxreq > 0) {
		selectmax = false;
	}
	
	//logic to determine if a field is checked...
	if (selectnum < minreq || !selectmax) {
		return false;
	}
	return true;
}

// -----------------------------------------
//            arrElementExists
//This function returns the array index of the string expVal
//It can be used to check for the existence of a value in
//an array -seg 18Apr05
// -----------------------------------------
function arrElementExists(arr, expVal)
{
	var retIndex = '-1';
	for (var i = 0; i < arr.length; i++) {
		if (arr[i] == expVal) {
			retIndex = i;
		}
	}
	return retIndex;
}

// -----------------------------------------
//            arrElementDelete
//This function returns the array without the value passed
//for deletion.  delete 'delVal' from 'arr' -seg 18Apr05
// -----------------------------------------
function arrElementDelete(arr, delVal) {
	retArr = Array();
	for (i = 0; i < arr.length; i++) {
		if (arr[i] != delVal) {
			retArr.push(arr[i]);
		}
	}
	return retArr;
}

// -----------------------------------------
//                  trim
// Trim leading/trailing whitespace off string
// -----------------------------------------
function trim(str)
{
  return str.replace(/^\s+|\s+$/g, '')
}

function stripNewLines(instr){
	outstr = instr;
	remnewlines = /[\r\n]/g;
	
	// Axe all \n chars
	outstr = outstr.replace(remnewlines, '');
	outstr = trim(outstr);
	
	//alert(retstatements);
	return outstr;
}


// -----------------------------------------------------------
//                   doSubmitSkillsInterview
//  validates the Skills Interview Form's Name and Address fields
// -----------------------------------------------------------

function doSubmitSkillsInterview(formObj, requiredfields){

	if(checkCookie()){ 
if(validateAll(formObj, requiredfields)){
		
			errstr = validateSkillsInterview(formObj);
			if(errstr != "") {
				alert(errstr);
				return false;
			}
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


// -----------------------------------------------------------
//                   validateSkillsInterview
// validateSkillsInterview validates the Skills Interview Form
// -----------------------------------------------------------
function validateSkillsInterview(formObj){

	requiredfields = '';
	errstr = '';
	
	//Check to make sure all the radio elements are filled
	var formlength = formObj.elements.length;
	
	for(var i = 0; i < formlength; i++){
		
		if(formObj.elements[i].type == 'radio'){
			var name = formObj.elements[i].name;
			var radio_choice = false;

			for (counter = 0; counter < document.getElementsByName(name).length; counter++){
				if (document.getElementsByName(name)[counter].checked){
					radio_choice = true; 
				}
			}

			if (!radio_choice){
			    errstr = 'Please complete all the questions provided before submitting this interview';
				
			}
			
		}
		
	}
	
	//Strip newlines and html from the Additional Info field
	if (formObj.res1detail.value) {
		valstr = formObj.res1detail.value;
		
		valstr = tagStrip('', valstr, 'none');
		valstr = stripNewLines(valstr);
		
		formObj.res1detail.value = valstr;
	}
	
	//document.skillsinterviewstep4form.submit(); papertrail left here per SEG
	
	return errstr;	
}

// -----------------------------------------
//               pageJump
// This is the function that allows a user
// to naviate between steps on Resume/Job
// forms
// -----------------------------------------
function pageJump( formName, action ) {
	hiddenelement = 'pagejump';
	formobj = eval( 'document.' + formName );
	formobj.action = action;
	
	//assumes the <form name="blah" id="[name]ID">
	formID = formName + 'ID';
	lclSubmitEvent = getSubmitStatements(formID);
	
	if (eval(lclSubmitEvent)) {
		formobj.submit();
	}		
}

// -----------------------------------------
//               getSubmitStatements
// Returns a String containing statements
// contained in a form's onsubmit or the string
// 'null' if the attribute does not exist.
// -----------------------------------------
function getSubmitStatements(sFormID) {
	lclOnSubmit = getAttributeVal( sFormID, 'onsubmit' ) + ' ';
	lclOnSubmit = trim(cleanEventStatements(lclOnSubmit));
	
	//If no validation is nessecary for this form...
	if (lclOnSubmit == 'null' || lclOnSubmit == '')
		lclOnSubmit = true;
	
	return lclOnSubmit;
}

// -----------------------------------------
//                  setAttributeVal
// Adds/sets the value of atname to atvalue in element
// -----------------------------------------
function setAttributeVal(element, atname, atvalue) {
	element.setAttribute(atname, atvalue);
}

// -----------------------------------------
//                  setAttributeVal
// Returns the string value of a tagID's attribute (atname)
// -----------------------------------------
function getAttributeVal(element, atname) {
	rettribute = '';
	elem = document.getElementById(element);
	
	if (atname in elem) {
		rettribute = elem[atname];
	}
	
	//alert(rettribute);
	return rettribute;
}


// -----------------------------------------
//                  cleanEventStatements
//This function removes the return statement
// beginning 'onsubmit' attribute values from
// form tags and removed the function wrapper
// from the Event
// -----------------------------------------
function cleanEventStatements(statements){
	retstatements = statements;
	remnewlines = /[\r\n]/g;
	remfunchead = /^[\w ( )]*\{/;
	remfuncfoot = /\}[\w \W]*$/;
	
	// Axe all \n chars then delete everything to { and everything from }
	retstatements = retstatements.replace(remnewlines, '');
	retstatements = retstatements.replace(remfunchead, '');
	retstatements = retstatements.replace(remfuncfoot, '');
	retstatements = trim(retstatements);
	
	retstatements = retstatements.replace(/^return/, '');
	//alert(retstatements);
	return retstatements;
}

// -----------------------------------------
//                  disableValidateAll
//This function disables the onsubmit form
//validation for formObj
// -----------------------------------------
function disableValidateAll(formObj){
	formObj.onsubmit = function() { return true; };
}

// -----------------------------------------
//                  popup
// This is the standard handler for popup windows
// -----------------------------------------
function popup(pageurl, height, width, anchor) {
	popupFullOpt(pageurl, height, width, anchor, 0, 0, 'yes', 'yes');
	}
	
// -----------------------------------------
//                  popupFullOpt
// This is the main handler for popup windows
// -----------------------------------------
function popupFullOpt(pageurl, height, width, anchor, lft, top, scroll, resize) {
	var popupWin1 = null;
	if (!popupWin1) {
		//Store window object in global
		if (anchor != '')
			pageurl += '#' + anchor;
			popupWin1 = window.open(pageurl,"popupWin1","width=" + width + ",height=" + height + ",scrollbars=" + scroll + ",resizable=" + resize )
			popupWin1.focus()
			}
			else {
				//Window already exists - bring it forward
				popupWin1.focus()
				if (popupWin1.href != pageurl) {
				popupWin1.href = pageurl;
			}
		}
	}


// -----------------------------------------
//                  checkCookie
// This function tries to write a cookie and
// returns false if it fails
// -----------------------------------------
function checkCookie(){ 
	try{
		document.cookie = "login";
	} catch(e) { }
	var co = document.cookie;
	if(co == null || co == "") { 
		return false;
	} 
	else {
		return true;
	}
} 

//AUTOMATICALLY SELECT RADIO BUTTON 'radioObj' WITH VALUE OF 'str'
function segAutoCheck(radioObj, str)
{
	if (radioObj) {
		radiolength = radioObj.length;
			for (i = 0; i < radiolength; i++) {
			if (radioObj[i].value == str)
				radioObj[i].checked = 1;
		}
	}
}

function checkboxGroupToggle(formObj, checkboxname, toggleto) {
	var objCheckBoxes = formObj.elements[checkboxname];
	if(!objCheckBoxes) return;
	var countCheckBoxes = objCheckBoxes.length;
	if(!countCheckBoxes){
		objCheckBoxes.checked = toggleto;
	}
	else { // set the check value for all check boxes
		for(var i = 0; i < countCheckBoxes; i++)
		objCheckBoxes[i].checked = toggleto;
	}
	return true;
}

function validatePet(formObj, requiredfields) {
   if(validateAll(formObj, requiredfields)){
			errstr = '';
			if (formObj.numrandomjobs.value != '' &&
			    parseInt(formObj.numrandomjobs.value) == 0) {
			    errstr += "\nNumber of Random Jobs must be greater than 0";
			}
			if (formObj.resultsppg.value != '' &&
			    parseInt(formObj.resultsppg.value) == 0) {
			    errstr += "\nResults per page must be greater than 0";
			}
			
			if (formObj.numrandomjobs.value != '' && 
			    formObj.resultsppg.value != '' ) {
			    
			    if ( parseInt(formObj.numrandomjobs.value) >
			         parseInt(formObj.resultsppg.value) ) {
				     errstr += "\nResults per page cannot be less than Number of Random Jobs";
				}
			}
			
			//TP 13154
			if (formObj.resultsppg.value > 100) {
		errstr += "\nPlease choose a number less than 100 for Results per page";
	                      }
	
			if(errstr != "") {
				alert(errstr);
				return false;
			}
			return true;
   }
   else {
			return false;
   }
}

function textCounter( field, countId, maxlimit ) {
    countElem = document.getElementById(countId);
    if ( field.value.length > maxlimit )
    {
      field.value = field.value.substring( 0, maxlimit );
      var errstr = 'This field supports a max length of ' + maxlimit + ' characters.';
      alert( errstr );
    }
    
    countElem.innerHTML = maxlimit - field.value.length;
    return true;
}

function validateAllAndDisable(formObj, requiredfieldids, submitbutton) {
    var returncode = validateAll(formObj, requiredfieldids);
     
    if (returncode) {
        submitbutton.disabled = true;
    } else {   
        submitbutton.disabled = false; 
    }
    return returncode;
}

function validateResumeUploadPage2(formObj, requiredfields) {
   if(validateAll(formObj, requiredfields)){
		errstr = '';
       
        for ( var i = 1; i < 4; i ++) {
            var category = document.getElementsByName('categories' + i)[0];
            var categoryText = category.options[category.selectedIndex].text;
            var categoryValue = category.options[category.selectedIndex].value;
           
            if (categoryValue != '') {
                var occupation = document.getElementById('occupation' + i);
                if(!validateSelect(occupation)){
                    errstr = errstr+"\n Please select an occupation for " + categoryText + ".\n";
                }
            }
        }
		if(errstr != "") {
			alert(errstr);
			return false;
		}
		return true;
   }
   else {
       return false;
   }
}
