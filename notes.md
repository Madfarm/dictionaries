namespaces can be declared like this, with no brackets
namespace DogHatGuy;

this will make the namespace contain all types in that file

## Dictionaries
A collection consisting of key value pairs
create one with the following syntax:

Dictionary<key type, value type> nameOfDictionary = new Dictionary<key type, value type>


access values by putting the key in square brackets
nameOfDictionary[key];



key, value pairs can also be added via square bracket syntax:
nameOfDictionary[key] = value;


trying to access a key that isn't in the dictionary it will throw a KeyNotFoundException that can be caught in a try catch block


we can grab just the values or just the keys by creating the associated collection and then using the Keys property or the Values property

Dictionary<key type, value type>.ValueCollection valueColl = nameOfDictionary.Values;

### Checking and Removing
.ContainsKey(key)      - returns a boolean
.ContainsValue(value)  - return a boolean
.Remove(key)           - removes a given key,value pair




### Iterating
Utilize the KeyValuePair struct in a foreach loop to iterate over a dictionary, access the keys and values via the Key and Value property

foreach (KeyValuePair<key type, value type> kvp in nameOfDictionary)
{
    Console.WriteLine($"This is the key{kvp.Key}, and this is the value {kvp.Value}")
}