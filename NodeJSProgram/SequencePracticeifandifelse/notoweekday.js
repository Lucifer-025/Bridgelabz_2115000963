
function numberToWeekday(num) {
    const weekdays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    return weekdays[num - 1] || "Invalid Input";
}