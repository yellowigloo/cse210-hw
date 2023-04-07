class User{
    List<Goal> _goals = new List<Goal>();
    string _name;
    int _points;
    public User(){
        _points = 0;
    }
    public User(int level){
        _points = level;
    }
}