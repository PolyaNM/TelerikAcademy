function isBiggerThanNeighbours(position, array) {
    return (array[position] > array[position + 1]) && (array[position] > array[position - 1]);
}