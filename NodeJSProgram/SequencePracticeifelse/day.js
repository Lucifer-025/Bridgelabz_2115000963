let day = parseInt(process.argv[2]); // Read from command line
let month = parseInt(process.argv[3]); // Read from command line

if ((month === 3 && day >= 20) || (month === 6 && day <= 20) || (month > 3 && month < 6)) {
    console.log("True - Date is in range");
} else {
    console.log("False - Date is out of range");
}