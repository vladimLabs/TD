using UnityEngine.TestTools;
using UnityEngine;
using UnityEngine.Assertions;

public class CharacterMovementTests : MonoBehaviour
{
    [UnityTest]
    public IEnumerator CharacterMovesForward()
    {
        // Создайте экземпляр вашего персонажа
        GameObject character = new GameObject();
        CharacterController controller = character.AddComponent<CharacterController>();

        // Задайте начальные условия
        Vector3 startPosition = character.transform.position;
        character.transform.position = startPosition;

        // Выполните движение вперед
        controller.Move(Vector3.forward * Time.deltaTime);

        // Подождите один кадр
        yield return null;

        // Проверьте, что персонаж переместился
        Assert.IsTrue(character.transform.position.z > startPosition.z);
    }
}