using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Fusion;

internal sealed class NetworkSceneManagerDummy : _0021_00210
{
	public bool IsBusy => false;

	public Scene MainRunnerScene
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return SceneManager.GetActiveScene();
		}
	}

	public void Initialize(NetworkRunner runner)
	{
	}

	public void Shutdown()
	{
	}

	public bool IsRunnerScene(Scene scene)
	{
		return true;
	}

	public bool MoveGameObjectToScene(GameObject gameObject, SceneRef sceneRef)
	{
		//IL_003f: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (byte)(int)ex2 != 0;
	}

	public SceneRef GetSceneRef(GameObject gameObject)
	{
		//IL_003f: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (SceneRef)ex2;
	}

	public unsafe bool TryGetPhysicsScene2D(out PhysicsScene2D scene2D)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_0035: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6838]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PhysicsScene2D defaultPhysicsScene = Physics2D.defaultPhysicsScene;
		ref PhysicsScene2D reference = ref *(PhysicsScene2D*)defaultPhysicsScene;
		return true;
	}

	public unsafe bool TryGetPhysicsScene3D(out PhysicsScene scene3D)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_0035: Expected Ref, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PhysicsScene defaultPhysicsScene = Physics.defaultPhysicsScene;
		ref PhysicsScene reference = ref *(PhysicsScene*)defaultPhysicsScene;
		return true;
	}

	public void MakeDontDestroyOnLoad(GameObject obj)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.DontDestroyOnLoad(obj);
	}

	public void MoveToRunnerScene(GameObject obj)
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4390]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Scene activeScene = SceneManager.GetActiveScene();
		SceneManager.MoveGameObjectToScene(obj, activeScene);
	}

	public NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, NetworkLoadSceneParameters parameters)
	{
		//IL_003f: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkSceneAsyncOp)ex2;
	}

	public NetworkSceneAsyncOp UnloadScene(SceneRef sceneRef)
	{
		//IL_003f: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (NetworkSceneAsyncOp)ex2;
	}

	public void OnSceneInfoChanged()
	{
	}

	public SceneRef GetSceneRef(string sceneNameOrPath)
	{
		//IL_003f: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		ArgumentNullException ex2 = new ArgumentNullException();
		return (SceneRef)ex2;
	}

	public bool OnSceneInfoChanged(NetworkSceneInfo sceneInfo, NetworkSceneInfoChangeSource changeSource)
	{
		return false;
	}
}
