package example.lamprakis.chatapplication;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.firebase.ui.database.FirebaseRecyclerAdapter;
import com.firebase.ui.database.FirebaseRecyclerOptions;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.Query;
import com.google.zxing.BarcodeFormat;
import com.journeyapps.barcodescanner.BarcodeEncoder;

public class Second extends AppCompatActivity {
    private RecyclerView recyclerView;
    private ImageButton qrbutton, sendbutton;
    private EditText message;
    private Bitmap bitmap;
    private String name;

    private DatabaseReference databaseReference;
    private FirebaseRecyclerAdapter<Messages, MessageViewHolder> firebaseRecyclerAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        databaseReference = FirebaseDatabase.getInstance().getReference();

        bitmap = BitmapFactory.decodeByteArray(getIntent().getByteArrayExtra("byteArray"),0,getIntent().getByteArrayExtra("byteArray").length);

        name = getIntent().getStringExtra("name");

        message = (EditText)findViewById(R.id.messagetxt);
        recyclerView = (RecyclerView)findViewById(R.id.recycler);
        qrbutton = (ImageButton)findViewById(R.id.qrbutton);
        sendbutton = (ImageButton)findViewById(R.id.sendbutton);

        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

    }


    @Override
    protected void onStart() {
        super.onStart();

        sendbutton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (message.getText().toString().trim().length() != 0) {
                    String text = message.getText().toString();
                    String key = databaseReference.child("Chat").push().getKey();
                    Messages messages = new Messages(name, message.getText().toString(), "text");
                    databaseReference.child("Chat").child(key).setValue(messages);
                    message.setText("");
                }
            }
        });

        qrbutton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (message.getText().toString().trim().length() != 0) {
                    String text = message.getText().toString();
                    String key = databaseReference.child("Chat").push().getKey();
                    Messages messages = new Messages(name, message.getText().toString(), "qr");
                    databaseReference.child("Chat").child(key).setValue(messages);
                    message.setText("");
                }
            }
        });

        Query query = databaseReference.child("Chat");

        FirebaseRecyclerOptions<Messages> options = new FirebaseRecyclerOptions.Builder<Messages>()
                .setQuery(query, Messages.class)
                .build();

        firebaseRecyclerAdapter = new FirebaseRecyclerAdapter<Messages, MessageViewHolder>(options) {
            @Override
            protected void onBindViewHolder(@NonNull MessageViewHolder holder, int position, @NonNull final Messages model) {
                if (model.getName().equals(name)) {
                    holder.setImage(bitmap);
                }else {
                    holder.profileimage.setImageDrawable(getResources().getDrawable(R.drawable.ic_person_black_24dp));
                }

                holder.setName(model.name);

                if (model.getType().equals("text")) {
                    holder.setMessage(model.message);
                }else {
                    try {
                        BarcodeEncoder barcodeEncoder = new BarcodeEncoder();
                        Bitmap bitmap1 = barcodeEncoder.encodeBitmap(model.getMessage(), BarcodeFormat.QR_CODE, 200, 200);
                        holder.qrimage.setImageBitmap(bitmap1);
                        holder.qrimage.setOnClickListener(new View.OnClickListener() {
                            @Override
                            public void onClick(View view) {
                                Toast.makeText(Second.this, model.message, Toast.LENGTH_SHORT).show();
                            }
                        });
                    } catch(Exception e) {

                    }
                }
            }

            @Override
            public MessageViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
                View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.messages, parent, false);
                return new MessageViewHolder(view);
            }
        };

        recyclerView.setAdapter(firebaseRecyclerAdapter);
        firebaseRecyclerAdapter.startListening();

    }


    public class MessageViewHolder extends RecyclerView.ViewHolder {
        View view;

        public ImageView profileimage, qrimage;
        public TextView profilename, textmessage;

        public MessageViewHolder(View itemView) {
            super(itemView);

            view = itemView;

            profileimage = (ImageView)view.findViewById(R.id.profileimage);
            qrimage = (ImageView)view.findViewById(R.id.qrimage);
        }

        public void setName(String name) {
            profilename = (TextView)view.findViewById(R.id.profilename);
            profilename.setText(name);
        }

        public void setImage(Bitmap imagebit) {
            profileimage = (ImageView)view.findViewById(R.id.profileimage);
            profileimage.setImageBitmap(imagebit);
        }

        public void setMessage(String message) {
            textmessage = (TextView)view.findViewById(R.id.textmessage);
            textmessage.setText(message);
        }


    }


}
