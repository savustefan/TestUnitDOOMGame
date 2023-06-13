using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class ScoreboardTest
{
    [Test]
    public void AddScore_10()
    {      
        Scoreboard scoreboard = Scoreboard.Instance;

        scoreboard.AddScore(10);
        int score = scoreboard.GetScore();

        Assert.AreEqual(10, score);
    }
}