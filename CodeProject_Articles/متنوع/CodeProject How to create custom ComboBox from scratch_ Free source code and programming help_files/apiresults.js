function indeed_clk(a,sig) { var hr = a.href; var si = hr.indexOf('&jsa='); if (si > 0) return; var jsh = hr + '&jsa=' + sig; a.href = jsh; }
