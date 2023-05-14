public class ReductionGoal : Goal{

    public override void SaveGoal(){
        //asda
    }
    public override void RecordEvent(){
        //dasda
    }

    public override int CalculatePoints(){
        return 1;
    }

    public ReductionGoal askInformation(){
        return new ReductionGoal();
    }
}