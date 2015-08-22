
#region::vect2D
//C#のジェネリックはC++のテンプレートと異なり演算子オーバーロードはできない
public struct Vect2D<T>
    where T : struct
{
    public T x;
    public T y;
    public Vect2D(T _x, T _y)
    {
        x = _x;
        y = _y;
    }
}
#endregion
