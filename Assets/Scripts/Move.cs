using UnityEngine;

public class Move : MonoBehaviour {
    public Transform player;
    [SerializeField] //Позволяет сериализовать переменные вне зависимости от их области видимости. Очень полезный атрибут, который позволяет сделать все переменные класса приватными, но настраиваемыми в инспекторе. 
    private float speed = 10f;
    private void OnMouseDrag() //Функция отслеживающая движение мыши
    {
        Vector3 mousePos =Camera.main.ScreenToWorldPoint (Input.mousePosition); //данные о координатах мыши относительно глобальной камере
        mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
        mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
        player.position = new Vector2(mousePos.x,player.position.y);//По оси y не двигается
        
    }

}
