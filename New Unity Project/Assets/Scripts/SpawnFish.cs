using UnityEngine;

public class CubeRotation : MonoBehaviour
{
	public float rotationSpeed = 6.5f, moveSpeed = 8f, range = 10f; // скорость вращения, скорость перемещения, допустимый размах для передвижения
	Vector3 startPosition; // Vector3 начала координат
	Transform fish; // private переменная для хранения ссылки на Transform объекта
	Vector3 direction = Vector3.up; // переменная для стартового направления движения
	// можно сделать Vector3 публичной переменной и задавать нужно направление в инспекторе

	void Start()
	{
		fish = gameObject.GetComponent<Transform>(); // получаем ссылку на компонент Trnasform
		startPosition = fish.position; // запоминаем стартовые координаты
	}

	void Update()
	{
		fish.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); // вращаем куб вокруг своей оси
		fish.Translate(direction * Time.deltaTime * moveSpeed); // двигаем куб вверх-вниз

		if (fish.position.y <= startPosition.y - range) // если мы дошли до пика startPosition.y - range
		{
			direction = Vector3.up; // сменяем направление движения
		}

		else if (fish.position.y >= startPosition.y + range) // если мы дошли до пика startPosition.y + range
		{
			direction = Vector3.down; // сменяем направление движения
		}
	}
}