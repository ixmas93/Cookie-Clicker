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
    
}
