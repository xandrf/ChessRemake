using System.IO;
namespace ChessCore
{
    public class Position
    {
        public int x {get;set;}
        public int y {get;set;}
        public Position(int x,int y){
            this.x=x-1; this.y=y-1;
        }
    }
}