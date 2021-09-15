function validateaddcourse(thisForm) {
    var title = document.forms["myform"]["title"].value;

    if (title == "") {
        alert("Title must be filled out");
        return false;
    }
    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');
    if (select.value) {
        alert("Well done! You added a course!")
    }
}

function validateaddtrainer(thisForm) {
    var name = document.forms["myform"]["name"].value;
    var lname = document.forms["myform"]["lname"].value;
    var textpattern = /^[a-zA-Z\s]{4,15}$/;
    if (name == "") {
        alert("FirstName must be filled out");
        return false;
    } else if (name.match(textpattern)) {

    } else {
        alert("Only letters MinLength=>4 & MaxLength=>15");
        return false;
    }
    if (lname == "") {
        alert("Lastname must be filled out");
        return false;
    } else if (lname.match(textpattern)) {

    } else {
        alert("Only letters MinLength=>4 & MaxLength=>15");
        return false;
    }
    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');
    if (select.value) {
        alert("Well done! You added a trainer!")
    } else {
        alert("You failed!")
    }
}


function validateaddstudent(thisForm) {
    var name = document.forms["myform"]["name"].value;
    var lname = document.forms["myform"]["lname"].value;
    var age = document.forms["myform"]["age"].value;
    var email = document.forms["myform"]["email"].value;
    var emailpattern = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
    var textpattern = /^[a-zA-Z\s]{4,15}$/;

    if (name == "") {
        alert("Firstname must be filled out");
        return false;
    } else if (name.match(textpattern)) {

    } else {
        alert("Only letters MinLength=>4 & MaxLength=>15");
        return false;
    }
    if (lname == "") {
        alert("Lastname must be filled out");
        return false;
    } else if (lname.match(textpattern)) {

    } else {
        alert("Only letters MinLength=>4 & MaxLength=>15");
        return false;
    }
    if (age == "" ) {
        alert("Age must be filled out");
        return false;
    } else if (age<18 || age>45 ) {
        alert("Age must be bigger than 18 and smaller than 45");
        return false;
    } 
    if (email == "") {
        alert("Email must be filled out");
        return false;
    } else if (email.match(emailpattern)) {

    } else {
        alert("Email must be like this pattern : alexandros@hotmail.com")
        return false;
    }
    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');
    if (select.value) {
        alert("Well done! You added a student!")
    } else {
        alert("You failed!")
    }
}

function validateaddassignment(thisForm) {
    var title = document.forms["myform"]["title"].value;
    var subdate = document.forms["myform"]["subdate"].value;

    if (title == "") {
        alert("Title must be filled out");
        return false;
    }
    if (subdate == "") {
        alert("Subdate must be filled out");
        return false;
    }
    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');
    if (select.value) {
        alert("Well done! You added an assignment!")
    } else {
        alert("You failed!")
    }
}


function enablecourse() {
    document.getElementById("title").disabled = false;
    document.getElementById("stream").disabled = false;
}

function enabletrainer() {
    document.getElementById("name").disabled = false;
    document.getElementById("lname").disabled = false;
    document.getElementById("stream").disabled = false;
}

function enablestudent() {
    document.getElementById("name").disabled = false;
    document.getElementById("lname").disabled = false;
    document.getElementById("age").disabled = false;
    document.getElementById("email").disabled = false;
    document.getElementById("stream").disabled = false;
}

function enableassignment() {
    document.getElementById("title").disabled = false;
    document.getElementById("stream").disabled = false;
    document.getElementById("subdate").disabled = false;
}

function trainerpercourse(thisForm) {

    if (thisForm.trainer.value == "") {
        alert("Please select a trainer");
        thisForm.trainer.focus();
        return false;
    } select = document.getElementById('trainer');

    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');
    if (select.value) {
        alert("Well done! You added a Trainer per Course!")
    } else {
        alert("You failed!")
    }
}

function studentpercourse(thisForm) {

    if (thisForm.student.value == "") {
        alert("Please select a student");
        thisForm.student.focus();
        return false;
    } select = document.getElementById('student');

    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');
    if (select.value) {
        alert("Well done! You added a Student per Course!")
    } else {
        alert("You failed!")
    }
}

function assignmentpercourse(thisForm) {

    if (thisForm.title.value == "") {
        alert("Please select a assignment");
        thisForm.title.focus();
        return false;
    } select = document.getElementById('title');

    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');
    if (select.value) {
        alert("Well done! You added an Assignment per Course!")
    } else {
        alert("You failed!")
    }
}

function courseperstudentpertrainer(thisForm) {

    if (thisForm.stream.value == "") {
        alert("Please select a stream");
        thisForm.stream.focus();
        return false;
    } select = document.getElementById('stream');

    if (thisForm.student.value == "") {
        alert("Please select a student");
        thisForm.student.focus();
        return false;
    } select = document.getElementById('student');

    if (thisForm.trainer.value == "") {
        alert("Please select a trainer");
        thisForm.trainer.focus();
        return false;
    } select = document.getElementById('trainer');

    if (select.value) {
        alert("Well done! You added a course per student per trainer!")
    } else {
        alert("You failed!")
    }
}
