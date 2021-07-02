function Validate(value1) {

    if (value1 == document.getElementById("male").value) {
        document.getElementById("male").checked = true;
    }
    if (value1 == document.getElementById("female").value) {
        document.getElementById("female").checked = true;
    }
    if (value1 == document.getElementById("others").value) {
        document.getElementById("others").checked = true;
    }
}