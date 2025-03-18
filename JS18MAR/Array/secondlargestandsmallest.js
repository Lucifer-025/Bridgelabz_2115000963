function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    for (let num of arr) {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    console.log("Generated Array:", arr);
    console.log("Second Largest:", secondLargest);
    console.log("Second Smallest:", secondSmallest);
}

let randomNumbers = Array.from({ length: 10 }, () => Math.floor(100 + Math.random() * 900));
findSecondLargestAndSmallest(randomNumbers);
