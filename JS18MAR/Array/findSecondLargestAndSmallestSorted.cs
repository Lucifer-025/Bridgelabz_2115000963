function findSecondLargestAndSmallestSorted(arr) {
    arr.sort((a, b) => a - b);
    console.log("Sorted Array:", arr);
    console.log("Second Smallest:", arr[1]);
    console.log("Second Largest:", arr[arr.length - 2]);
}

let randomNumbers2 = Array.from({ length: 10 }, () => Math.floor(100 + Math.random() * 900));
findSecondLargestAndSmallestSorted(randomNumbers2);
