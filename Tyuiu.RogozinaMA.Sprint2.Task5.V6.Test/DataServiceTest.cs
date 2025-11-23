[TestMethod]
public void ValidFindCardNameAndValueQueenSpades()
{
    DataService ds = new DataService();
    int m = 1;
    int k = 12;
    string wait = "дама пик";
    string res = ds.FindCardNameAndValue(m, k);
    Assert.AreEqual(wait, res);
}

[TestMethod]
public void ValidFindCardNameAndValueSixDiamonds()
{
    DataService ds = new DataService();
    int m = 3;
    int k = 6;
    string wait = "шестерка бубен";
    string res = ds.FindCardNameAndValue(m, k);
    Assert.AreEqual(wait, res);
}

[TestMethod]
public void ValidFindCardNameAndValueAceHearts()
{
    DataService ds = new DataService();
    int m = 4;
    int k = 14;
    string wait = "туз червей";
    string res = ds.FindCardNameAndValue(m, k);
    Assert.AreEqual(wait, res);
}
