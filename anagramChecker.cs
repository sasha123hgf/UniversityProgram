bool anagramChecker(string first, string second)
{
    if(first.Length != second.Length)
        return false;

    if(first == second)
        return true;

    Dictionary<char, int> pool = new Dictionary<char, int>();
    foreach(char element in first.ToCharArray())
    {
        if(pool.ContainsKey(element))
            pool[element]++;
        else
            pool.Add(element, 1);
    }
    foreach(char element in second.ToCharArray())
    {
        if(!pool.ContainsKey(element))
            return false;
        if(--pool[element] == 0)
            pool.Remove(element);
    }
    return pool.Count == 0;
}