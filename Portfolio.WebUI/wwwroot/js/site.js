function clickedMe(item) {
    var id = $(item).attr("id");
    if (!$("#" + id).hasClass("active")) {
        alert("doesnt");
    } else {
        alert("have!");
    }
}