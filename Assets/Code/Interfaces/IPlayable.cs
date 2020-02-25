public interface IPlayable {
    void Jump();
    void FirePrimary();
    void FireSecondary();
    void Move(float x, float y, float deltaTime);
}
