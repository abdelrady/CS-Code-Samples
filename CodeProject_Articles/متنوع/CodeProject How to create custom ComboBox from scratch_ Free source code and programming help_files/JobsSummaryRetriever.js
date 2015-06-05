// Copyright (c) 2008, The Code Project. All rights reserved.

function RetrieveJobsSummary(divName, imageName, objectId, objectTypeId, countryId, attributesList) 
{
    var placeHolder = GetJobSummaryPlaceHolder(divName);
    if (placeHolder.length > 0) 
    {
        var queryString = "/Script/Jobs/Ajax/GetRelatedJobs.aspx?";
        queryString += "objId="         + objectId;
        queryString += "&typeId="       + objectTypeId;
        queryString += "&cntrId="       + countryId;
        queryString += "&atrList="      + attributesList;

        $(placeHolder).load(queryString);

        HideLoadImage(imageName);
    }
    
    return false;
}

function GetJobSummaryPlaceHolder(objectName) 
{
    var object = $("div[name=" + objectName + "]");
    if (object.length > 0)
        object.css("display", "inline");
        
    return object;
}

function HideLoadImage(imageName) 
{

    var image = $("img[name=" + imageName + "]");
    if (image.length > 0)
        $(image).css("display", "none");

    return true;
}
