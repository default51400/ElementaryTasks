namespace ElementaryTasks
{
    public interface ISurface<ICell>
    {
        int Height { get; set; }
        int Width { get; set; }
        Cell[,] Cells { get;}

        Cell[,] GetEmptySurface();
    }
}