using NUnit.Framework;
using UnityEngine;

namespace Tests.Editor
{
    [TestFixture]
    public class ComponentActivatorTests
    {
        [Test]
        public void Active_GameObject_WhenStatusIsActive()
        {
            var gameObject = new GameObject();
            gameObject.SetActive(false);

            var middleMenGameObject = new GameObject();
            middleMenGameObject.AddComponent<Com>()
        }
    }
}