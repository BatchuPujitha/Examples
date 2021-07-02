function display_refreshtime() {
    var refresh = 1000; 
    mytime = setTimeout('display_currenttime()', refresh)
}

function display_currenttime() {
    var x = new Date()
    document.getElementById('currenttime').innerHTML = x;
    display_refreshtime();
}