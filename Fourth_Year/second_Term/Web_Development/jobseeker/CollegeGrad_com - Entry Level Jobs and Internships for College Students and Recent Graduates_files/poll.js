function __Poll()
{
    var p = document.getElementById("PollData");
    p.ans = null;
    p.x = null;
    
    p.Vote = function(){
        if(this.ans==null) return;    
        this.Update({Action:"Vote",Answer: this.ans});
        return void(0);
    }
    
    p.Results = function(){
        this.Update({Action: "Results"});
        return void(0);
    }
    
    p.Display = function(){
        this.Update({});
        return void(0);
    }
    
    p.onAjaxFinished = new Array();
    
    p.Update = function(url){
        this.style.width = "302px"; //this.offsetWidth+"px";
        this.style.height = this.offsetHeight+"px";
        this.innerHTML = "<div style=\"text-align:center;\"><img src=\"graphics/loading.gif\" alt=\"\" style=\"margin: 15px;\" /></div>";
        url = $.extend({ Random: Math.random() }, url);
        this.x = $.get("/includes/poll.aspx?",url, function(data){
            
                window.Poll.innerHTML = data;
                //window.Poll.style.width = "auto";
                window.Poll.style.height = "auto";
    
                if(window.Poll.onAjaxFinished)
                for(var i=0;i<window.Poll.onAjaxFinished.length;i++)
                    if(typeof window.Poll.onAjaxFinished[i]!="undefined")
                        window.Poll.onAjaxFinished[i]();
           
        });
    }
    window.Poll = p;
}
__Poll();