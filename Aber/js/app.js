/**
 * Created by Sandeep Reddy on 9/2/2015.
 */

$(function(){
    var $orders = $('#tb');
    var $name = $('#name');
    var $dae = $('#dae');
    var $assign = $('#assign');

    $('#but').on('click',function(){
    var newOrder = {
        name: $name.val(),
        dae: $dae.val(),
        assign: $assign.val(),
    };
	//alert(newOrder.name);
	 $orders.append('<tr><td>' + newOrder.name + '</td><td>' + newOrder.date + '</td><td>' + newOrder.assigned + '</td></tr>');

    });

});