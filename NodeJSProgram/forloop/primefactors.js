function primeFactors(n) {
    console.log(`Prime factors of ${n}:`);
    while (n % 2 === 0) {
        process.stdout.write(2 + " ");
        n = n / 2;
    }