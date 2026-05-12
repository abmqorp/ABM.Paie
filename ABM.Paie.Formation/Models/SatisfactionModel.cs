namespace ABM.Paie.Formation.Models;

public sealed record SatisfactionModel(double Percentage, DateOnly Date, int SurveyedCount, int HourCount, int TrainedCount);
