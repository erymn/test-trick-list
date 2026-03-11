string[] strList = ["eat","tea","tan","ate","nat","bat"];

var map = new Dictionary<string, List<string>>();

foreach(var str in strList){
    var sortedList = string.Join("", str.OrderBy(s => s));
    //Console.WriteLine(sortedList);

    if(map.ContainsKey(sortedList)){
        map[sortedList].Add(str);
    }else{
        map[sortedList] = new List<string>{str};
    }
}

foreach(var item in map){
    Console.WriteLine($"{item.Key}: [{string.Join(", ", item.Value)}]");
}

