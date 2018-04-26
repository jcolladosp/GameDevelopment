#### Kinematic

- transform.Translate
- transform.Rotate
- transform.Scale
- 3 * Time.deltaTime = 3 metros x segundo



#### Physics
private Rigidbody rigidbody;

rigidbody = GetComponent<Rigidbody> ();

rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
										0,
									Input.GetAxis("Vertical"))*forceValue);



if (Input.GetButtonDown ("Jump") && Mathf.Abs (rigidbody.velocity.y) < 0.01f) {
			rigidbody.AddForce (Vector3.up * jumpValue, ForceMode.Impulse);
		}



#### Basic Methods

- Awake -> Primer metodo ejecutado, antes que el Start()
- Start -> Segundo inicializador, solo se ejecuta si el objeto esta activado
- Update -> Se ejecuta en cada frame. Se usa para objetos no físicos o interacciones de los usuarios
- FixedUpdate -> se llama a intervalos regulares. Usado para cambios en el rigidbody y gameobject.
- LateUpdate -> Se invoca después de todos los updates. Usado para objetos que necesitan datos de otro update de otro objeto

#### Collisions

- OnCollisionEnter()
- OnCollisionStay()
- OnCollisionExit()

#### Triggers

- OnTriggerEnter
- OnTriggerStay
- OnTriggerExit

#### Messages

- SendMessage -> ejecuta un metodo en un gameobject concreto
- BroadcastMessage ->