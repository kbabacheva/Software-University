(function () {
    $('<div>').text('First div').appendTo('body');
    $('<h2>').text('Header before div').prependTo('body');
    $('<ul>').appendTo('body');
    for (var i = 1; i < 6; i++) {
        $('<li>').text(i + ' items').appendTo('ul');
    }
    $('<ul id = "reversed">').appendTo('body');
    for (var i = 1; i < 6; i++) {
        $('<li>').text(i + ' items').prependTo('#reversed');
    }
}())