function generateBirthMonths() {
    let birthMonths = new Map();

    for (let i = 1; i <= 50; i++) {
        let month = Math.floor(Math.random() * 12) + 1;

        if (!birthMonths.has(month)) {
            birthMonths.set(month, []);
        }
        birthMonths.get(month).push(`Person ${i}`);
    }

    console.log("Birth Month Distribution:");
    birthMonths.forEach((people, month) => {
        console.log(`Month ${month}: ${people.length} individuals - ${people}`);
    });
}

generateBirthMonths();
