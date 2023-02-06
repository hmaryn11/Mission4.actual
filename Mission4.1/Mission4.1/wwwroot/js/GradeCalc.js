//gather info from inputs from button id
$("#buttonCalc").click(function () {

    var finalNum;
    var finalLet;

    var assign = $("#assign").val();
    var gp = $("#gp").val();
    var quiz = $("#quiz").val();
    var mid = $("#mid").val();
    var final = $("#final").val();
    var intex = $("#intex").val();

 // var text = "Assign: " + assign + ", GP: " + gp + ", Quiz: " + quiz + ", Mid: " + mid + ", Final: " + final + ", Intex: " + intex;

    finalNum = ((assign * .5) + (gp * .1) + (quiz * .1) + (mid * .1) + (final * .1) + (intex * .1));

    if (finalNum >= 94)
    {
        finalLet = "A"
    }
    else if (finalNum >= 90)
    {
        finalLet = "A-"
    }
    else if (finalNum >= 87)
    {
        finalLet = "B+"
    }
    else if (finalNum >= 84)
    {
        finalLet = "B"
    }
    else if (finalNum >= 80)
    {
        finalLet = "B-"
    }
    else if (finalNum >= 77)
    {
        finalLet = "C+"
    }
    else if (finalNum >= 74)
    {
        finalLet = "C"
    }
    else if (finalNum >= 70)
    {
        finalLet = "C-"
    }
    else if (finalNum >= 67)
    {
        finalLet = "D+"
    }
    else if (finalNum >= 64)
    {
        finalLet = "D"
    }
    else if (finalNum >= 60)
    {
        finalLet = "D-"
    }
    else
    {
        finalLet = "E"
    }

    var text = "Your grade in this class is " + finalLet + "."

   $("#finalGrade").text(text);
})
