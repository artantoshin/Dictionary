var mike = new KeyValuePair<int, string>(56, "Mike");
var employees = new List<KeyValuePair<int, string>>() { mike };
var people = new Dictionary<int, string>(employees)
{
    [5] = "Tom",
    [6] = "Sam",
    [7] = "Bob",
};

// получаем элемент по ключу 6
string sam = people[6];  // Sam
Console.WriteLine(sam);  // Sam
// переустанавливаем значение по ключу 6
people[6] = "Mike";
Console.WriteLine(people[6]);  // Mike

// добавляем новый элемент по ключу 22
people[22] = "Eugene";
Console.WriteLine(people[22]);  // Eugene

foreach (var employee in people)
{
    Console.WriteLine($"key: {employee.Key}  value: {employee.Value}");
}

// условная телефонная книга
var phoneBook = new Dictionary<string, string>();

// добавляем элемент: ключ - номер телефона, значение - имя абонента
phoneBook.Add("+123456", "Tom");
// альтернативное добавление
// phoneBook["+123456"] = "Tom";

// Проверка наличия
var phoneExists1 = phoneBook.ContainsKey("+123456");    // true
Console.WriteLine($"+123456: {phoneExists1}");
var phoneExists2 = phoneBook.ContainsKey("+567456");    // false
Console.WriteLine($"+567456: {phoneExists2}");
var abonentExists1 = phoneBook.ContainsValue("Tom");      // true
Console.WriteLine($"Tom: {abonentExists1}");
var abonentExists2 = phoneBook.ContainsValue("Bob");      // false
Console.WriteLine($"Bob: {abonentExists2}");

// удаление элемента
phoneBook.Remove("+123456");

// проверяем количество элементов после удаления
Console.WriteLine($"Count: {phoneBook.Count}"); // Count: 0