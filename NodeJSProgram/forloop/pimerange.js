function findPrimesInRange(start, end) {
    console.log(`Prime numbers between ${start} and ${end}:`);
    for (let i = start; i <= end; i++) {
        if (isPrime(i)) {
            process.stdout.write(i + " ");
        }
    }
    console.log();
}