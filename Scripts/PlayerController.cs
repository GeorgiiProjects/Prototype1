using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Сделал переменные приватными так как больше не нуждаюсь их видеть в инспекторе, а настроил значения в коде.
    // float speed = 12.0f; float - это переменная, speed - имя переменной, = оператор, 12.0f присваевоемое десятичное значение переменной.
    // private float speed = 12.0f; доступно только внутри класса PlayerController и не видна в инспекторе.

    // скорость передвижения машины 12f
    private float speed = 12.0f;
    // скорость поворота машины влево или вправо 35f
    private float turnSpeed = 35.0f;
    // Переменная создана для движения машины влево или вправо при помощи клавиатуры.
    private float horizontalInput;
    // Переменная создана для движения машины вперед или назад при помощи клавиатуры.
    private float verticalInput;

    // Обновление анимации каждый кадр
    void Update()
    {
        // Input.GetAxis("Horizontal"); получаем доступ к менеджеру в unity Project settings - Input Manager - Axes - Horizontal - Name (Horizontal)
        // Теперь видим в инспекторе что значения движения меняются от -1 до 1, но машина не двигается.
        horizontalInput = Input.GetAxis("Horizontal");

        // Input.GetAxis("Vertical"); получаем доступ к менеджеру в unity Project settings - Input Manager - Axes - Vertical - Name (Vertical)
        // Теперь видим в инспекторе что значения движения меняются от -1 до 1, но машина не двигается.
        verticalInput = Input.GetAxis("Vertical");

        // transform.Translate(Vector3.forward) машина двигается вперед по оси z автоматически.
        // Time.deltaTime машина двигается на любом пк с одинаковой скоростью.
        // Time.deltaTime * speed машина двигается со скоростью speed метров в секунду.
        //  * verticalInput машина может двигаться вперед или назад с клавиатуры.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Машина двигается влево или вправо в зависимости от значения переменной turnSpeed.
        // * horizontalInput машина может двигаться влево или вправо с клавиатуры.
        // Time.deltaTime * turnSpeed машина поворачивается с одинаковой скоростью на любом пк, со скоростью 35 метров в секунду.
        // transform.Rotate(Vector3.up получаем доступ к углу поворота машины по оси y, за счет чего машина начинает поворачивать правильно.
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
