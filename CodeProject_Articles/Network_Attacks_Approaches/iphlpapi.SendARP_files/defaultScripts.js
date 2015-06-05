function TopicBarMouseOver()
{
	TopicBar.className='TopicBarHover';
}

function TopicBarMouseOut()
{
	TopicBar.className='TopicBar';
}

function IsEditing()
{
	return DynamicTopicBar.style.display == 'block';
}

function SetEditing(flag)
{
	var isEditing = IsEditing();
	if (isEditing == flag)
		return; 
	isEditing = flag;
	if (isEditing)
	{
		StaticTopicBar.style.display = 'none';
		DynamicTopicBar.style.display = 'block';
	}
	else
	{
		StaticTopicBar.style.display = 'block';
		DynamicTopicBar.style.display = 'none';
	}
}

function BodyClick()
{
	SetEditing(false);
}

function TopicBarClick(event)
{
	event.cancelBubble = 'true';
	if (IsEditing())
		return;

	// Grab these dimensions before SetEditng() to get them before the control is hidden (thus h=0;w=0!)
	var staticWide = StaticTopicBar.offsetWidth;
	var staticHigh = StaticTopicBar.offsetHeight;

	SetEditing(true);

	DynamicTopicBar.left = TopicBar.offsetLeft;
	DynamicTopicBar.top = TopicBar.offsetTop;
	DynamicTopicBar.width = TopicBar.width;
	DynamicTopicBar.height = TopicBar.height;

	var tbi = tbinput();
	tbi.left = DynamicTopicBar.left;
	tbi.top = DynamicTopicBar.top;
	tbi.width = staticWide;
	tbi.height = staticHigh;
	tbi.value = '';
	tbi.focus();
	tbi.select();
}

function tbinput()
{
	return 	document.getElementById('TopicBarInputBox');
}

function MainHeight()
{
    var answer = document.body.clientHeight;
    var e;
     return answer;
}
						
function MainWidth()
{
	var answer = document.body.clientWidth;
	var e;
	
	e = document.getElementById("Sidebar");
	if (e != null)
		answer -= e.scrollWidth;
	 return answer;
}

function nav(s)
{
	if (navigator.appName.indexOf('Microsoft') != -1)
		window.navigate(s);
	else
		location=s;
}
			
function diffToggle()
{
	if (showDiffs.checked)
		showChanges();
	else
		hideChanges();
}

function showVersion()
{
	nav(VersionList.value);
}