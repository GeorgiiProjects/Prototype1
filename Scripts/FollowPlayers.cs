using UnityEngine;

public class FollowPlayers : MonoBehaviour
{
    // public GameObject это класс или тип с именем player и он виден в инспекторе, если его сделать приватным то это сломает камеру.
    // помещаем префаб автомобиля (Vehicle) в GameObject player (В инспекторе Main Camera).
    public GameObject player;

    // private Vector3 offset - приватная переменна типа Vector 3, которая настраивает камеру с заданными координатами с именем offset, 
    // задаем новые значения камеры в new Vector3 x,y,z (0,5,-7)
    // видна только внутри класса FollowPlayers и не видна в инспекторе.
    private Vector3 offset = new Vector3(0, 5, -7);

    // используем метод LateUpdate(), так как в простом Update() непонятно что должно двигаться первым камера или автомобиль, 
    // из-за этого все дергается, в LateUpdate() сначала двигается автомобиль затем камера за ним.
    void LateUpdate()
    {
        // transform - дает доступ к компоненту transform в инспекторе - MainCamera.
        // position - дает доступ к позиции камеры x,y,z.
        // player.transform.position - дает доступ к позиции автомобиля, x,y,z в инспекторе.
        // transform.position = player.transform.position; - теперь камера будет следовать за автомобилем, но под автомобилем
        // + offset - теперь камера будет следовать нормально за автомобилем.
        transform.position = player.transform.position + offset;
    }
}
