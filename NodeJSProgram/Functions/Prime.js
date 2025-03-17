function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) return false;
    }
    return true;
}
function findPalindrome(num) {
    return parseInt(num.toString().split("").reverse().join(""));
}

function checkPrimeAndPalindrome(num) {
    if (isPrime(num)) {
        let palNum = findPalindrome(num);
        console.log(`${num} is Prime.`);
        console.log(`Palindrome of ${num} is ${palNum}.`);
        if (isPrime(palNum)) {
            console.log(`Palindrome ${palNum} is also Prime.`);
        } else {
            console.log(`Palindrome ${palNum} is NOT Prime.`);
        }
    } else {
        console.log(`${num} is NOT Prime.`);
    }
}
