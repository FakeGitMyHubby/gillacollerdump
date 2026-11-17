using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Fusion;

public struct SceneLoadDoneArgs
{
	public readonly SceneRef SceneRef;

	public readonly NetworkObject[] SceneObjects;

	public readonly Scene Scene;

	public readonly GameObject[] RootGameObjects;

	public unsafe SceneLoadDoneArgs(SceneRef sceneRef, NetworkObject[] sceneObjects, Scene scene = default(Scene), GameObject[] rootGameObjects = null)
	{
		//IL_0015: Expected Obj, but got Ref
		//IL_0032: Expected Obj, but got Ref
		SceneRef = sceneRef;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = sceneObjects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		obj2 = rootGameObjects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
