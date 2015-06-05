var req;

function Initialize()
{

    try
    {
        req=new ActiveXObject("Msxml2.XMLHTTP");
    }
    catch(e)
    {
        try
        {
            req=new ActiveXObject("Microsoft.XMLHTTP");
        }
        catch(oc)
        {
            req=null;
        }
    }

    if(!req&&typeof XMLHttpRequest!="undefined")
    {
        req=new XMLHttpRequest();
    }

}

function SendQuery(urlin, key)
{
    Initialize();
    var url=urlin+key;

    if(req!=null)
    {
        req.onreadystatechange = Process;
        req.open("GET", url, true);
        req.send(null);

    }

}

function CallPage(urlin)
{
	  Initialize();
    var url=urlin;

    if(req!=null)
    {
  
        req.onreadystatechange = Process;
        req.open("GET", url, true);
  			//alert(url);
        req.send(null);

    }

}


function Process()
{
    if (req.readyState == 4)
        {
        // only if "OK"
            if (req.status == 200)
            {
                if(req.responseText=="")
                {
                    document.getElementById("autocomplete").innerHTML = "";
										HideDiv("autocomplete");
                    
                }
                else
                {
                    ShowDiv("autocomplete");
                    document.getElementById("autocomplete").innerHTML = 
                                                      req.responseText;
                }
            }
            else
            {
                document.getElementById("autocomplete").innerHTML=
                    "There was a problem retrieving data:<br>" 
                    + req.statusText;
            }
        }
}

function ShowDiv(divid)
{
   if (document.layers) document.layers[divid].visibility="show";
   else document.getElementById(divid).style.visibility="visible";
}

function HideDiv(divid)
{
	if (document.layers) 
	{
		document.layers[divid].visibility="hide";
	}
	else 
	{
		document.getElementById(divid).style.visibility="hidden";
	}
}



function captcha()
{
	document.getElementById("bb").value="crap";
	var obj = document.getElementById("bb");
	alert(obj.value);
}