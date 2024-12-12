using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(800, 600, "God Jul");

Raylib.SetTargetFPS(60);

Vector2 leftEye = new(350, 275);
Vector2 rightEye = new(450, 275);

while (Raylib.WindowShouldClose() == false)
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Red);

    Raylib.DrawCircle(400, 300, 100, Color.Yellow);
    Raylib.DrawCircleV(leftEye, 10, Color.Black);
    Raylib.DrawCircleV(rightEye, 10, Color.Black);

    Raylib.EndDrawing();
}
