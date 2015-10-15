(function () {
    if (localStorage.length === 0) {
        var info = '<div><label for="name">Name: </label><input type="text" id="name" /><input type="button" id="button" value="submit"/><p>Now reload the browser...</p></div>';
        $(info).appendTo('#wrapper');
        $('#button').on('click', function () {
            var name = $('#name').val();
            sessionVisits = 0;
            totalVisits = 1;
            localStorage['name'] = name;
            localStorage['visit'] = 0;
            localStorage['totalVisits'] = 1;
        })
    }
    else {
        localStorage['visit']++;
        localStorage['totalVisits']++;
        var info = '<div>Hello, ' + localStorage['name'] + '</div><div>  Session visits : ' + localStorage['visit'] + '  Total visits: ' + localStorage['totalVisits'] + '</div>';
        $(info).appendTo('#wrapper');
    }
    //localStorage.clear();
}())