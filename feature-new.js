const employees = [{ one: 1, two: 2 }, { one: 3, two: 4 }, { one: 5, two: 6 }]

for (const item of employees) {
    console.log(`Feature-New: ${item.one} and ${item.two}`)
    console.log(`Feature-Second: ${item.one} and ${item.two}`)
}