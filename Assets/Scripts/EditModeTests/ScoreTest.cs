using System;
using System.Collections;
using System.Collections.Generic;
using Modelo;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ScoreTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayerStartsWithZeroCookies()
    {
        Assert.AreEqual(0,new Score().playerTotalCookies);
        // Use the Assert class to test conditions
    }
    [Test]
    public void AddCookies()
    {
        var Score = new Score();
        Score.AddCookies();
        Assert.AreEqual(1, Score.playerTotalCookies);
    }
    [Test]
    public void NoGrannyNoCookie()
    {
        var Score = new Score();
        Score.AddCookiesSinceDate(DateTime.Now,DateTime.Now.AddSeconds(300));
        Assert.AreEqual(0,Score.playerTotalCookies);
    }
    [Test]
    public void asdoasjodso()
    {
        var Score = new Score();
        Score.AddCookiesSinceDate(DateTime.Now,DateTime.Now);
        Assert.AreEqual(0, Score.playerTotalCookies);
    }
    [Test]
    public void asdasdasdvcx()
    {
        var Score = new Score();
        Score.AddTimedCookies();
        Assert.AreEqual(0, Score.playerTotalCookies);
    }
    [Test]
    public void sdfdsdfsdfds()
    {
        var Score = new Score(playerTotalCookies:0,cookiesIncrementAmmount:1,timedCookiesIncrementAmount:1);
        Score.AddCookiesSinceDate(DateTime.Now,DateTime.Now.AddSeconds(1));
        Assert.AreEqual(1,Score.playerTotalCookies);
    }
    [Test]
    public void CantBuyWithNoCookies()
    {
        var Score = new Score();
        Assert.IsFalse(Score.HasEnoughCookies(999));
        Assert.IsTrue(Score.HasEnoughCookies(0));
        Score.AddCookies();
        Assert.IsTrue(Score.HasEnoughCookies(1));
    }
}
