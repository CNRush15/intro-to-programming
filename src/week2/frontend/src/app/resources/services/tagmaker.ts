export function tagMaker(tagList: string): string[] {
    // Split the input string into words, convert to lowercase, and filter out duplicates
    const uniqueTags = Array.from(new Set(
        tagList
            .toLowerCase() // Convert to lowercase
            .split(' ')    // Split by spaces
            .filter(tag => tag) // Remove empty strings
    ));

    return uniqueTags;
}