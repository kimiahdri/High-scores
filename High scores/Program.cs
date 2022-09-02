using System;





using System.Collections.Generic;





using System.Linq;










public class HighScores





{





    private List<int> scores { get; set; }










    public HighScores(List<int> list)





    {





        scores = list;





    }










    public List<int> Scores()





    {





        return scores;





    }










    public int Latest()





    {





        return scores.Last();





    }










    public int PersonalBest()





    {





        return scores.Max();





    }










    public List<int> PersonalTopThree()





    {





        return (from i in scores orderby i descending select i).Take(3).ToList();





    }





}



